using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;


public class OnClickStartBtn : MonoBehaviour
{
    public List <GameObject> animatingObj;
    Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // On Click of the start button start the animations
    public void OnClickStart()
    {
        for (int i = 0; i < animatingObj.Count; i++ )
        {
             animator = animatingObj(i).GetComponenet<Animator>();
            animator.SetBool("ActivateAnimation", true);
        }
    }
}
