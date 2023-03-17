using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptOutScript : MonoBehaviour
{
    public bool request_optout;
    private bool isAlreadyRequesting;
    [SerializeField] float backNumber;

    private float timeBetweenKeyPresses = 5.7f; // Adjust as necessary
    private float lastKeyPressTime;


    public GameObject exitWarning;
    Animator eW_Animator;
    // Start is called before the first frame update
    void Start()
    {
        eW_Animator = exitWarning.GetComponent<Animator>();

        isAlreadyRequesting = false;
        request_optout = false;
        backNumber = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (backNumber == 0 && isAlreadyRequesting == false)
            {
                isAlreadyRequesting = true;
                eW_Animator.SetTrigger("isWarned");

                if (Time.time - lastKeyPressTime < timeBetweenKeyPresses)
                {
                    print("quitted");
                    Application.Quit();
                    isAlreadyRequesting = false;
                }
                else
                {
                    isAlreadyRequesting = false;
                }
                lastKeyPressTime = Time.time;;
            }
        }

        // if request IS EQUAL TO TRUE
        if (request_optout != false)
        {
            request_optout = false;
            print("exited menu");
        }
    }

}
