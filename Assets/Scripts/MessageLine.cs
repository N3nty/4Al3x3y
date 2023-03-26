using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageLine : MonoBehaviour
{
    [SerializeField] private Text uiText;

    public void ChangeText(string newText)
    {
        uiText.text = newText;
    }
}
