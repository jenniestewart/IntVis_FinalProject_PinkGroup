using UnityEngine;
using UnityEngine.SceneManagement;
public class LOADMENU : MonoBehaviour
{
     public void OnLoadButtonCliked()
    {
        SceneManager.LoadScene("Main Menu");

        Debug.Log("transform to Main Menu page...");
    }      
}
