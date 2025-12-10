using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour
{
    //This script enambles quitting functionality.
    public void QuitApplication()
    {
        Application.Quit();
        Debug.Log("Application has quit.");
    }
}
