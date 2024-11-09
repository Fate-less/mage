using System.Collections;
using UnityEngine;
using TMPro;

public class WriterEffect : MonoBehaviour
{
    public TextMeshPro textMeshPro;
    [TextArea] public string[] texts; // Array to hold multiple texts
    public float typeSpeed = 0.05f;
    public float delayBetweenTexts = 2f; // Delay before switching to the next text

    public void StartTyping()
    {
        if (textMeshPro != null && texts.Length > 0)
        {
            StartCoroutine(ShowTextsSequentially());
        }
    }

    private IEnumerator ShowTextsSequentially()
    {
        foreach (string text in texts)
        {
            yield return StartCoroutine(ShowText(text));
            yield return new WaitForSeconds(delayBetweenTexts);
            textMeshPro.text = ""; // Clear the text before the next one
        }
    }

    private IEnumerator ShowText(string text)
    {
        textMeshPro.text = ""; // Clear the text initially

        for (int i = 0; i < text.Length; i++)
        {
            textMeshPro.text += text[i];
            yield return new WaitForSeconds(typeSpeed);
        }
    }
}
