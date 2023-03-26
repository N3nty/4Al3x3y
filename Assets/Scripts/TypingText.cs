using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TypingText : MonoBehaviour
{
    
    [SerializeField] private TextMeshProUGUI uiText;
    [SerializeField] private float typingSpeed;
    private void OnEnable()
    {
        StartCoroutine(Type());
    }
    private void OnDisable()
    {
        StopCoroutine(Type());
    }

    private IEnumerator Type()
    {
        yield return new WaitForSeconds(typingSpeed);
        uiText.text = "печатает..";
        yield return new WaitForSeconds(typingSpeed);
        uiText.text = "печатает.";
        yield return new WaitForSeconds(typingSpeed);
        uiText.text = "печатает";
        yield return new WaitForSeconds(typingSpeed);
        uiText.text = "печатает.";
        yield return new WaitForSeconds(typingSpeed);
        uiText.text = "печатает..";
        yield return new WaitForSeconds(typingSpeed);
        uiText.text = "печатает...";
        StartCoroutine(Type());
    }
}
