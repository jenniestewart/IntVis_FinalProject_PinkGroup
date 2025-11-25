using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manage_Slider : MonoBehaviour
{// Start is called once before the first execution of Update after the MonoBehaviour is created
    private Slider slider;
    public List<GameObject> teethObj;
    void Start()
    {
        Slider slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    public void TeethPosition()
      {
            for (int i = 0; i < teethObj.Count; i++)
            {
                Animator teethAnim = teethObj[i].GetComponent<Animator>();
                teethAnim.SetFloat("TeethPosition", slider.value);
            }
      }
}
