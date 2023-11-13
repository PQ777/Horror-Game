using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCon : MonoBehaviour
{
    public float yMouse;
    public float xMouse;
    public float camMaxX;
    public float camMinX;
    public float camMaxY;
    public float camMinY;

    [SerializeField]
    private float ySensitivity = 3f;
    private float xSensitivity = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        yMouse = Input.GetAxis("Mouse Y");
        xMouse = Input.GetAxis("Mouse X");

        Vector3 newRotation = transform.localEulerAngles;
        newRotation.x -= yMouse * ySensitivity;
        newRotation.y -= xMouse * xSensitivity;

        if(camMinX > newRotation.x)
        {
            if(newRotation.x > 180)
            {
                newRotation.x = camMinX;
            }
        }

        if(newRotation.x > camMaxX)
        {
            if(180 > newRotation.x)
            {
                newRotation.x = camMaxX;
            }
        }

        if(camMinY > newRotation.y)
        {
            if(newRotation.y > 180)
            {
                newRotation.y = camMinY;
            }
        }

        if(newRotation.y > camMaxY)
        {
            if(180 > newRotation.y)
            {
                newRotation.y = camMaxY;
            }
        }

        transform.localEulerAngles = newRotation;
    }
}
