using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UiFunctionandText : MonoBehaviour
{
    public Button hideBtn;
    public TMP_Text infoText1;
    public TMP_Text infoText2;
    public Image background;
    public RawImage arrow;
    

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
        arrow.gameObject.SetActive(true);
    }

    void HideAllUI()
    {
        hideBtn.gameObject.SetActive(false);
        infoText1.gameObject.SetActive(false);
        infoText2.gameObject.SetActive(false);
        background.gameObject.SetActive(false);
         arrow.gameObject.SetActive(false);
    }
}