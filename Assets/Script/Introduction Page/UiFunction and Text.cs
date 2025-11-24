using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UiFunctionandText : MonoBehaviour
{
     public Button showTextBtn;
    public Button hideBtn;
    public Button closeTextBtn;
    public TMP_Text infoText;

    void Start()
    {
        showTextBtn.onClick.AddListener(ShowText);
        hideBtn.onClick.AddListener(HideAllUI);
        closeTextBtn.onClick.AddListener(CloseTextAndBtn);
    }

    void OnMouseDown()
    {
        showTextBtn.gameObject.SetActive(true);
        hideBtn.gameObject.SetActive(true);
    }

    void ShowText()
    {
        infoText.gameObject.SetActive(true); 
        closeTextBtn.gameObject.SetActive(true);
    }

    void CloseTextAndBtn()
    {
        infoText.gameObject.SetActive(false);
        closeTextBtn.gameObject.SetActive(false);
    }

    void HideAllUI()
    {
        showTextBtn.gameObject.SetActive(false);
        hideBtn.gameObject.SetActive(false);
        infoText.gameObject.SetActive(false);
        closeTextBtn.gameObject.SetActive(false);
    }
}
