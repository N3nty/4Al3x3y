using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public struct Message 
{
    [TextArea]
    public string text;
    public Sender sender;
    public bool showNextMessage;
    public int nextMessageId;
    public UnityEvent eventAfterMessage;
}
