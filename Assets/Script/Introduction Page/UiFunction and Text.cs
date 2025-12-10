using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class YunaUiFunctionandText : MonoBehaviour
{
    public Button hideBtn;
    public Button showDetailBt;
    public TMP_Text infoText;

    void Start()
    {
        hideBtn.onClick.AddListener(HideAllUI);
    }

    void OnMouseDown()
    {
        showDetailBt.gameObject.SetActive(true);
        infoText.gameObject.SetActive(true);
        hideBtn.gameObject.SetActive(true);
    }

    void HideAllUI()
    {
        showDetailBt.gameObject.SetActive(false);
        hideBtn.gameObject.SetActive(false);
        infoText.gameObject.SetActive(false);
    }
}
