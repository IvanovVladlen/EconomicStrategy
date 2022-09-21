using UnityEngine;

public class Building : MonoBehaviour
{
    public Vector2Int Size = Vector2Int.one;
    public Renderer Renderer;

    public void SetTransparent(bool isAvailable)
    {
        if (isAvailable)
        {
            Renderer.material.color = Color.green;
        }
        else
        {
            Renderer.material.color = Color.red;
        }
    }

    public void SetNormal()
    {
        Renderer.material.color = Color.white;
    }
    private void OnDrawGizmos()
    {
        for(int x = 0; x < Size.x; x++)
        {
            for(var y = 0; y < Size.y; y++)
            {
                Gizmos.color = new Color(0.88f, 0f, 1f, 0.3f);
                Gizmos.DrawCube(transform.position + new Vector3(x, 0, y), new Vector3(1, .15f, 1));
            }
        }
    }
}
