using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Animations : MonoBehaviour
{
    private Animator AnimationController;
    // Start is called before the first frame update
    void Start()
    {
        AnimationController = GetComponent<Animator>();

        StartCoroutine(IntroWait());

    }

    IEnumerator IntroWait()
    {
        // 1.5 + 1.3 = 2.7 seconds -> Total time until Intro is finished.
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("Main Menu", LoadSceneMode.Additive);
        yield return new WaitForSeconds(1.2f);
        SceneManager.UnloadSceneAsync("Intro");
    }
}
