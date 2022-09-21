using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField]
    public float speed;
    public bool useCameraMovement;

    private int _screenWidth;
    private int _screenHeight;

    // Start is called before the first frame update
    void Start()
    {
        _screenWidth = Screen.width;
        _screenHeight = Screen.height;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 camPos = transform.position;

        if (Input.mousePosition.x <= 20)
        {
            camPos.x -= Time.deltaTime * speed;
        }
        else if(Input.mousePosition.x >= _screenWidth - 20)
        {
            camPos.x += Time.deltaTime * speed;
        }
        else if (Input.mousePosition.y <= 20)
        {
            camPos.z -= Time.deltaTime * speed;
        }
        else if (Input.mousePosition.y >= _screenHeight - 20)
        {
            camPos.z += Time.deltaTime * speed;
        }

        if (useCameraMovement)
        {
            transform.position = new Vector3(Mathf.Clamp(camPos.x, -150, 150), camPos.y, Mathf.Clamp(camPos.z, -150, 150));
        }
    }
}
