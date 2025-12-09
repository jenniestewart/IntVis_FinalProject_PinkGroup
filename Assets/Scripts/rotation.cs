using UnityEngine;

public class rotation : MonoBehaviour
{
   public float speedOfRotation = 20f;
    void Update()
    {
       transform.Rotate(Vector3.up, speedOfRotation * Time.deltaTime);
    }
}


//https://www.codespeedy.com/infinite-rotation-of-a-game-object-in-unity-3d-c/#google_vignette