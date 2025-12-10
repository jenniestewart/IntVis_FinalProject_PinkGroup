using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageGameObjectList : MonoBehaviour
{   
    public List<GameObject> myObjList = new List<GameObject>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).gameObject.SetActive(false);

                if (myObjList.Contains(transform.GetChild(i).gameObject))
                {
                    transform.GetChild(i).gameObject.SetActive(true);
                }
            }
        } 

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).gameObject.SetActive(true);
                transform.GetChild(i).GetComponent<Outline>().enabled = false;
                transform.GetChild(i).GetComponent<YunaToggleHighlightOnObj>().isClicked = false;
            }

            myObjList.Clear();
            
        }
    }

    public void RemoveAllHightlight(GameObject obj)
    {
         for (int i = 0; i < transform.childCount; i++)
            {
                if (transform.gameObject != obj)
                    transform.GetChild(i).GetComponent<YunaToggleHighlightOnObj>().OnClickHideBt();
                
            }
    }
}
