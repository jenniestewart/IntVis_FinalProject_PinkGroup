using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGums : MonoBehaviour
{
    public void OnLoadButtonCliked()
    {
        SceneManager.LoadScene("Gums");

        Debug.Log("transform to Gums Scene...");
    }
        
}
