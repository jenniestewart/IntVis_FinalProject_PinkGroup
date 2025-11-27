using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using System.Linq;

public class ManageQuestion : MonoBehaviour
{

    public GameObject userResponse; 

    public GameObject correctResponse; 
 
    public GameObject positiveFeedback;
     
    public GameObject negativeFeedback;

    public ToggleGroup myToggleGroup;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnConfirmClick()
    {
        //Compare user answer vs correct answer
        Toggle selectedToggle = myToggleGroup.ActiveToggles().FirstOrDefault();
        userResponse = selectedToggle.gameObject; 

        //Set All toggles as non interactable
        for (int i = 0; i < myToggleGroup.transform.childCount; i++)
        {
            myToggleGroup.transform.GetChild(i).GetComponent<Toggle>().interactable = false;
        }

        if (userResponse == correctResponse)
        {
            //Show Positive Feedback
            positiveFeedback.SetActive(true);

            //transform.parent.GetComponent<ManageQuiz>().score += 1;
        }
        else
        {
            //Show Negative Feedback
            negativeFeedback.SetActive(true);
        }
    }
}
