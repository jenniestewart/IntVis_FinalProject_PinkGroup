using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RemoveHighLight : MonoBehaviour
{
    //Calling List and creating a bool var
    public bool isClicked;
    public GameObject myManagerObj;

    private ManageGameObjectList myManagerObjListScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Outline, Finding the Manager, Getting list componenet
     transform.GetComponent<Outline>().enabled = true;

      myManagerObj = GameObject.Find("Manager"); 
      myManagerObjListScript = myManagerObj.transform.GetComponent<ManageGameObjectList>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClickHideBt()
    {
        
        if(!isClicked)
        { 
            transform.GetComponent<Outline>().enabled = false;
            myManagerObjListScript.myObjList.Remove(transform.gameObject);
        }
       
    }
}
