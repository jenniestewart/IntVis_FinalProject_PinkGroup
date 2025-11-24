using UnityEngine;

public class CameraReset : MonoBehaviour
{
    private Vector3 initialPosition;
    private Quaternion initialRotation;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        initialPosition = Camera.main.transform.position;
        initialRotation = Camera.main.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Camera.main.transform.position = initialPosition;
            Camera.main.transform.rotation = initialRotation;
        }
    }
}
