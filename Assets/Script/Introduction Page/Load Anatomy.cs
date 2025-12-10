using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadAnatomy : MonoBehaviour
{
    public void OnLoadButtonCliked()
    {
        SceneManager.LoadScene("Anatomy");

        Debug.Log("transform to Anatomy Scene...");
    }
        
}
