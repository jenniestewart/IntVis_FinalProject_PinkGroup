using UnityEngine;
using System.Collections;


public class Jennie_Coroutine : MonoBehaviour
{
    
    private IEnumerator myCoroutine;
    public int Stage1;
    private float time = 2.0f;
    private Animator myAnimator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        myAnimator = this.GetComponent<Animator>();

        print("Starting " + Time.time + " seconds");

        // Start function WaitAndPrint as a coroutine.

        myCoroutine = StartJennieCoroutine(2.0f);
        StartCoroutine(myCoroutine);

        print("Coroutine started");
    }


    public 
        IEnumerator StartJennieCoroutine(float time)
    {
        yield return new WaitForSeconds(time);
        Stage1 = 1;
        
    }
}
