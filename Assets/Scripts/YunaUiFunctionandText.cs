using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class YunaUiFunctionandText : MonoBehaviour
{
    public Button hideBtn;
    public TMP_Text infoText1;
    public TMP_Text infoText2;
    public Image background;
    public RawImage arrow1;
    public RawImage arrow2;
    

    void Start()
    {
        hideBtn.onClick.AddListener(HideAllUI);
    }

    void OnMouseDown()
    {
        infoText1.gameObject.SetActive(true);
        infoText2.gameObject.SetActive(true);
        hideBtn.gameObject.SetActive(true);
        background.gameObject.SetActive(true);
        arrow1.gameObject.SetActive(true);
        arrow2.gameObject.SetActive(true);
    }

    void HideAllUI()
    {
        hideBtn.gameObject.SetActive(false);
        infoText1.gameObject.SetActive(false);
        infoText2.gameObject.SetActive(false);
        background.gameObject.SetActive(false);
        arrow1.gameObject.SetActive(false);
        arrow2.gameObject.SetActive(false);
    }
}