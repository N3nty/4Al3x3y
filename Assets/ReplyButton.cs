using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReplyButton : MonoBehaviour
{
    public ReplyAction replyAction;
    public Text uiText;
    public Image buttonImage;
    public Button button;
    public int nextMessageId { get; set; }
    [SerializeField] private GameObject losePanel;
    [SerializeField] private GameObject winPanel;
    [SerializeField] private float replyReactionTime;
    [SerializeField] private StoryManager storyManager;

    public void SetReplyAction(string action)
    {
        switch (action)
        {
            case "NextLevel":
                replyAction = ReplyAction.NextLevel;
                break;
            case "Restart":
                replyAction = ReplyAction.RestartLevel;
                break;
            case "RestartLevel":
                replyAction = ReplyAction.RestartLevel;
                break;
            case "NextMessage":
                replyAction = ReplyAction.NextMessage;
                break;
        }
    }
    public void ChangeAnswerText(string newText)
    {
        uiText.text = newText;
    }
    public void Clicked()
    {
        
        StartCoroutine(Reply());
    }
    private IEnumerator Reply()
    {
        switch (replyAction)
        {
            case ReplyAction.RestartLevel:
                losePanel.SetActive(true);
                break;
            case ReplyAction.NextLevel:
                winPanel.SetActive(true);
                break;
            case ReplyAction.NextMessage:
                yield return StartCoroutine(storyManager.SpawnMessage(Sender.Owner, uiText.text));
                yield return new WaitForSeconds(replyReactionTime);
                storyManager.currentMessageId = nextMessageId;
                storyManager.ContinueDialog();
                break;
        }
    }
    public void DisableButton()
    {
        button.enabled = false;
        buttonImage.enabled = false;
        uiText.enabled = false;
    }
    public void EnableButton()
    {
        uiText.enabled = true;
        button.enabled = true;
        buttonImage.enabled = true;
    }
}
