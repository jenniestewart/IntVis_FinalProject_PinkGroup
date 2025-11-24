using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ManageTeethRotation : MonoBehaviour
{
    private float xRot = 0.0f;
    private float yRot = 0.0f;

    private Vector3 eulerRot;

    private Quaternion myInitialRotation;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myInitialRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKey(KeyCode.W))
        {
            xRot = 0.1f;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            xRot = -0.1f;
        }
        else
        {
            xRot = 0.0f;
        }*/

        if (Input.GetKey(KeyCode.D))
        {
            yRot = -0.1f;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            yRot = 0.1f;
        }
        else
        {
            yRot = 0.0f;
        }
        eulerRot = new Vector3(xRot, yRot, 0.0f);
        transform.Rotate(eulerRot, Space.Self);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.rotation = myInitialRotation;
        }
    }
}
