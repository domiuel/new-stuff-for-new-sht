using UnityEngine;
using UnityEngine.UI;

public class MenuParallax : MonoBehaviour
{
    public RectTransform imageTransform;
    public float moveModifier;
    public bool isOngoingParallax;

    private Vector2 startPosition;
    private Vector2 centerPosition;

    private void Start()
    {
        startPosition = imageTransform.anchoredPosition;
        centerPosition = new Vector2(Screen.width / 2f, Screen.height / 2f);

        isOngoingParallax = true;
    }

    private void Update()
    {
        if (isOngoingParallax != false)
        {
            Vector2 mousePosition = Input.mousePosition;
            Vector2 offset = (mousePosition - centerPosition) * moveModifier;
            imageTransform.anchoredPosition = startPosition + offset;
        }

    }
}