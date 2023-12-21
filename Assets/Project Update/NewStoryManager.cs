using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewStoryManager : MonoBehaviour
{
    [SerializeField] private Transform contentFolder;
    [SerializeField] private ScrollRect scrollRect;
    [SerializeField] private float typingSpeed;
    [SerializeField] private float reactionSpeed;
    [SerializeField] private GameObject ownerMessagePrefab;
    [SerializeField] private GameObject otherMessagePrefab;
    [SerializeField] private GameObject otherUITyping;
    [SerializeField] private GameObject ownerUITyping;
    [SerializeField] private NewMessage[] messages;
    public int currentMessageId { get; set; } = 0;

    private void Start()
    {
        StartCoroutine(Dialog());
    }


    public void ContinueDialog()
    {
        StartCoroutine(Dialog());
    }
    private IEnumerator Dialog()
    {
        NewMessage message = messages[currentMessageId];

        yield return StartCoroutine(SpawnMessage(message.sender, message.text));
        yield return new WaitForSeconds(reactionSpeed);

        if (message.showNextMessage) currentMessageId = message.nextMessageId;

        message.eventAfterMessage?.Invoke();

        if (message.showNextMessage) StartCoroutine(Dialog());
    }
    public IEnumerator SpawnMessage(Sender sender, string text)
    {
        if (sender == Sender.Owner)
        {
            ownerUITyping.SetActive(true);
            yield return new WaitForSeconds(CalculateTypingTime(text));
            ownerUITyping.SetActive(false);

            MessageLine spawnedMessage = Instantiate(ownerMessagePrefab, contentFolder).GetComponent<MessageLine>();
            spawnedMessage.ChangeText(text);
            GoToEndOfChat();

        }
        else
        {
            otherUITyping.SetActive(true);
            yield return new WaitForSeconds(CalculateTypingTime(text));
            otherUITyping.SetActive(false);

            MessageLine spawnedMessage = Instantiate(otherMessagePrefab, contentFolder).GetComponent<MessageLine>();
            spawnedMessage.ChangeText(text);
            GoToEndOfChat();
        }


    }
    private void GoToEndOfChat()
    {
        scrollRect.velocity = Vector2.up * 1500;
    }
    private float CalculateTypingTime(string text)
    {
        float typingTime = 0;
        foreach (var item in text)
        {
            typingTime += typingSpeed;
        }

        return typingTime;
    }

}

