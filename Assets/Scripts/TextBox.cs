using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBox : MonoBehaviour
{
    public RectTransform textBoxRect;
    public RectTransform textUIRect;
    public RectTransform lineRect;
    private void Start()
    {
        FitSizeToText();
    }

    private void FitSizeToText()
    {
        textBoxRect.sizeDelta = textUIRect.sizeDelta + Vector2.up * 20 + Vector2.right * 50f;
        lineRect.sizeDelta = new Vector2(lineRect.sizeDelta.x, textBoxRect.sizeDelta.y) + Vector2.up * 50;
    }
}
