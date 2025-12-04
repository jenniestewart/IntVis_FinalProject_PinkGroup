
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleHighlightOnObj : MonoBehaviour
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
         
        OnHighlightClick();
    }

    public void OnHighlightClick()
    {
        Debug.Log("Click On Object" + transform.name);

        myManagerObjListScript.RemoveAllHightlight(transform.gameObject);
        isClicked = !isClicked;
        
        if (isClicked)
        {
            transform.GetComponent<Outline>().enabled = true;
            myManagerObjListScript.myObjList.Add(transform.gameObject);
        }
        else
        {
            transform.GetComponent<Outline>().enabled = false;
            myManagerObjListScript.myObjList.Remove(transform.gameObject);
            Debug.Log("Not Clicked");
        }
    }

    public void OnClickHideBt()
    {
        isClicked = false;
        transform.GetComponent<Outline>().enabled = false;
        myManagerObjListScript.myObjList.Remove(transform.gameObject);
    }
}
