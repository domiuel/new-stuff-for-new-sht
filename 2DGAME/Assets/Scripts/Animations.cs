using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    private Animator AnimationController;
    // Start is called before the first frame update
    void Start()
    {
        AnimationController = GetComponent<Animator>();

        if (AnimationController != null)
        {
            print("game started");
            AnimationController.SetTrigger("tr_IntoStart");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
