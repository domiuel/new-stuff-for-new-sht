using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnimations : MonoBehaviour
{

    Animator b_Animator;
    void Start()
    {
        //Get the Animator attached to the GameObject you are intending to animate.
        b_Animator = gameObject.GetComponent<Animator>();
    }

    public void changeWhenHover()
    {
        b_Animator.SetTrigger("button_highlight");
    }

    public void changeWhenLeave()
    {
        b_Animator.SetTrigger("button_disabled");
    }

    public void buttonClicked()
    {
        b_Animator.SetTrigger("button_selected");
       
    }
}