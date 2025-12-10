using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ModelReset : MonoBehaviour
{
    public Button reloadButton;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (reloadButton != null)
        {
            reloadButton.onClick.AddListener(ReloadCurrentScene);
        }
    }

    // Update is called once per frame
    public void ReloadCurrentScene ()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName);
    }
}
