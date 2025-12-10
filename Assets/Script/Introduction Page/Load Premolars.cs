using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadPremolars : MonoBehaviour
{
    public void OnLoadButtonCliked()
    {
        SceneManager.LoadScene("Premolars");

        Debug.Log("transform to Premolars Scene...");
    }
        
}