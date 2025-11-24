using UnityEngine;
using TMPro;
using UnityEngine.Video;

public class ManagePlayerPrefs : MonoBehaviour
{
    public void OnClickSave(TextMeshProUGUI myTMProTest)
    {
      PlayerPrefs.SetString("UserName", myTMProTest.text);
    }

    public void OnClickGet()
    {
       string username = PlayerPrefs.GetString("UserName");
       Debug.Log(" Welcome to the Kingdom of Teeth " + username);
    }

    void OnApplicationQuit()
    {
        Debug.Log("Saving PlayerPrefs...");
        PlayerPrefs.Save();
    }
}
