using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class test : MonoBehaviour
{
    public Animator animator;
    public string excludedTag = "exclude";

    private void Start()
    {
        // Attach onClick event handler to each button
        Button[] buttons = FindObjectsOfType<Button>();
        foreach (Button button in buttons)
        {
            // Define a local variable to reference the current button
            Button currentButton = button;

            currentButton.onClick.AddListener(() =>
            {
                // Use the local variable to check if this button should be excluded
                if (!currentButton.CompareTag(excludedTag))
                {
                    // Find all other buttons that should play the animation
                    GameObject[] otherButtons = GameObject.FindGameObjectsWithTag("Button")
                        .Where(b => b != currentButton && !b.CompareTag(excludedTag))
                        .ToArray();

                    // Play the animation on each button
                    foreach (GameObject otherButton in otherButtons)
                    {
                        Animator otherAnimator = otherButton.GetComponent<Animator>();
                        if (otherAnimator != null)
                        {
                            otherAnimator.SetTrigger("choicetransition");
                        }
                    }
                }
            });
        }
    }
}
