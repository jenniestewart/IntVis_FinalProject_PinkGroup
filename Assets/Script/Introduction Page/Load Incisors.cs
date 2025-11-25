using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadIncisors : MonoBehaviour
{
    public void OnLoadButtonCliked()
    {
        SceneManager.LoadScene("Incisors");

        Debug.Log("transform to Incisors Scene...");
    }
        
}