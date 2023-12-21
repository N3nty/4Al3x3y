using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;




public class NewMessage : MonoBehaviour
{
    [TextArea]
    public string text;
    public Sender sender;
    public bool showNextMessage;
    public int nextMessageId;
    public UnityEvent eventAfterMessage;
}
