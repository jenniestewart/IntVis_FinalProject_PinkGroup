using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [Header("speed control")]
    public float moveSpeed = 5f;
    public float rotateSpeed = 100f;

    void Update()
    {   
        //"W/S"
        float forwardMove = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * forwardMove * moveSpeed * Time.deltaTime);
        //"A/D"
        float horizontalMove = 0f;
        if (Input.GetKey(KeyCode.A)) horizontalMove = -0.5f;
        if (Input.GetKey(KeyCode.D)) horizontalMove = 0.5f;

        Vector3 leftRightMove = transform.right * horizontalMove;
        leftRightMove.y = 0f;
        transform.Translate(leftRightMove * moveSpeed * Time.deltaTime, Space.World);
        //"Q/E"
        float rotateInput = 0f;
        if (Input.GetKey(KeyCode.Q)) rotateInput = 0.5f; 
        if (Input.GetKey(KeyCode.E)) rotateInput = -0.5f;
        transform.Rotate(Vector3.up * rotateInput * rotateSpeed * Time.deltaTime);
        //"K/I"
        float verticalRotateInput = 0f;
        if (Input.GetKey(KeyCode.K)) verticalRotateInput =0.5f;
        if (Input.GetKey(KeyCode.I)) verticalRotateInput =-0.5f;
        transform.Rotate(Vector3.right * verticalRotateInput * rotateSpeed * Time.deltaTime);
        //"U/J"
        float verticalMove = 0f;
        if (Input.GetKey(KeyCode.U)) verticalMove = 0.5f; 
        if (Input.GetKey(KeyCode.J)) verticalMove = -0.5f;
        Vector3 upDownMove = Vector3.up * verticalMove;
        transform.Translate(upDownMove * moveSpeed * Time.deltaTime, Space.World); 
    }
}