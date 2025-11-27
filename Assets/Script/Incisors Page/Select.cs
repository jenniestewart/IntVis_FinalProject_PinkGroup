using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slect : MonoBehaviour
{
    public bool isClicked = false;
    public GameObject myManagerObj;

    private ManageGameObjectList myManagerObjListScript;
    void Start()
    {
      transform.GetComponent<Outline>().enabled = false;

      myManagerObj = GameObject.Find("Manager"); 
      myManagerObjListScript = myManagerObj.transform.GetComponent<ManageGameObjectList>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        Debug.Log("Click On Object" + transform.name);
        
        isClicked = !isClicked;
        
        if (isClicked)
        {
            transform.GetComponent<Outline>().enabled = true;
            myManagerObjListScript.myObjList.Add(transform.gameObject);
            transform.parent.GetComponent<ManageTeethRotation>().enabled = true;
        }
        else
        {
            transform.GetComponent<Outline>().enabled = false;
            myManagerObjListScript.myObjList.Remove(transform.gameObject);
            transform.parent.GetComponent<ManageTeethRotation>().enabled = false;
        }
    }

}
