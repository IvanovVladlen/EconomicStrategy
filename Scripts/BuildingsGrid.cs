using UnityEngine;

public class BuildingsGrid : MonoBehaviour
{
    public Vector2Int GridSize = new Vector2Int(30, 30);

    private Building[,] _grid;
    private Building currentBuilding;
    private Camera _mainCamera;

    private void Awake()
    {
        _grid = new Building[GridSize.x, GridSize.y];
        _mainCamera = Camera.main;
    }

    public void StartPlacingBuilding(Building buildingPrefab)
    {
        if (currentBuilding != null)
        {
            Destroy(currentBuilding.gameObject);
            Debug.Log("delete currentBuilding");
        }

        Debug.Log("Instantiate currentBuilding");
        currentBuilding = Instantiate(buildingPrefab);
    }

    private void Update()
    {
        if (currentBuilding != null)
        {
            Debug.Log("currentBuilding");
            var groundPlane = new Plane(Vector3.up, Vector3.zero);
            Ray ray = _mainCamera.ScreenPointToRay(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));

            if (groundPlane.Raycast(ray, out float position))
            {
                Vector3 worldPos = ray.GetPoint(position);

                int x = Mathf.RoundToInt(worldPos.x);
                int y = Mathf.RoundToInt(worldPos.z);
                bool isAvailable = true;

                if (x < 0 || x > GridSize.x - currentBuilding.Size.x)
                    isAvailable = false;

                if (y < 0 || y > GridSize.x - currentBuilding.Size.y)
                    isAvailable = false;

                if(isAvailable && IsPlaceTaken(x, y))
                    isAvailable = false;

                currentBuilding.transform.position = new Vector3(x, 0, y);
                currentBuilding.SetTransparent(isAvailable);

                if (isAvailable && Input.GetMouseButtonDown(0))
                {
                    Build(x, y);
                }
            }
        }
    }

    private void Build(int placeX, int placeY)
    {
        for (int x = 0; x < currentBuilding.Size.x; x++)
        {
            for (var y = 0; y < currentBuilding.Size.y; y++)
            {
                _grid[placeX + x, placeY + y] = currentBuilding;
            }
        }

        currentBuilding.SetNormal();
        currentBuilding = null;
    }

    private bool IsPlaceTaken(int placeX, int placeY)
    {
        for (int x = 0; x < currentBuilding.Size.x; x++)
        {
            for (var y = 0; y < currentBuilding.Size.y; y++)
            {
                if(_grid[placeX + x, placeY + y] != null)
                    return true;
            }
        }
        return false;
    }
}
