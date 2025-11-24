using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;

public class ManageQuestion : MonoBehaviour
{

    public GameObject userResponse; 

    public GameObject correctResponse; 

 
    public GameObject postiveFeedback;
     
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
        userResponse = selectedToggle.GameObject; 

        if(userResponse == correctResponse)
        {
            //Show Positive Feedback
            positiveFeedback.SetActive(true);


        }
        else
        {
            //Show Negative Feedback 
            negativeFeedback.SetActive(true);
        }
    }
}
