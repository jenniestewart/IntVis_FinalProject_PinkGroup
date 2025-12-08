using UnityEngine;

public class rotation : MonoBehaviour
{
   public float speedOfRotation = 20f;
    void Update()
    {
       transform.Rotate(Vector3.up, speedOfRotation * Time.deltaTime);
    }
}
