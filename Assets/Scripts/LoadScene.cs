using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
   public void LoadNewScene(int index)
   {
       SceneManager.LoadScene(index);
       Debug.Log("Scene Loaded: " + index);
   }
}
