using UnityEngine;
using UnityEngine.SceneManagement;

public class LOADUSERINFO : MonoBehaviour
{
    public void OnLoadButtonCliked()
    {
        SceneManager.LoadScene("User Info");

        Debug.Log("transform to User Information page...");
    }    
}
