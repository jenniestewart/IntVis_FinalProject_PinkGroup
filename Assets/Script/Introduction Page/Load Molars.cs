using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMolars : MonoBehaviour
{
    public void OnLoadButtonCliked()
    {
        SceneManager.LoadScene("Molars");

        Debug.Log("transform to Molars Scene...");
    }
        
}