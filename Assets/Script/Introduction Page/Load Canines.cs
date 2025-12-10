using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadCanines : MonoBehaviour
{
    public void OnLoadButtonCliked()
    {
        SceneManager.LoadScene("Canine");

        Debug.Log("transform to Canine Scene...");
    }
        
}