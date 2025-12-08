using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
   
    void NextScene()
    {
        // Loads a new Scene
        SceneManager.LoadScene(1);
        Debug.Log("Scene Loaded");
    }

}
