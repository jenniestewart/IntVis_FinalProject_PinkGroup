using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YunaToggleHighlightOnObj : MonoBehaviour
{
    public bool isClicked = false;
    public GameObject myManagerObj;

    private YunaManageGameObjectList myManagerObjListScript;
    void Start()
    {
      transform.GetComponent<YunaOutline>().enabled = false;

      myManagerObj = GameObject.Find("Manager"); 
      myManagerObjListScript = myManagerObj.transform.GetComponent<YunaManageGameObjectList>();   
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
            transform.GetComponent<YunaOutline>().enabled = true;
            myManagerObjListScript.myObjList.Add(transform.gameObject);
        }
        else
        {
            transform.GetComponent<YunaOutline>().enabled = false;
            myManagerObjListScript.myObjList.Remove(transform.gameObject);
        }
    }

    public void OnClickHideBt()
    {
        isClicked = false;
        transform.GetComponent<YunaOutline>().enabled = false;
        myManagerObjListScript.myObjList.Remove(transform.gameObject);
    }
}
