using UnityEngine;
using UnityEngine.SceneManagement;
public class LOADMENU : MonoBehaviour
{
     public void OnLoadButtonCliked(int index)
    {
        SceneManager.LoadScene(index);

        Debug.Log("transform to Main Menu page...");
    }      
}
