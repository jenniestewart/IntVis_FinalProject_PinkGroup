using UnityEngine;
using UnityEngine.SceneManagement;

public class LOADINTRO1 : MonoBehaviour
{
       public void OnLoadButtonCliked()
    {
        SceneManager.LoadScene("Introduction page");

        Debug.Log("transform to Introduction page...");
    }    
}
