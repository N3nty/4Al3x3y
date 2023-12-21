using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelAvailability : MonoBehaviour
{
    [Header("Colors")]
    public Color unavailableColor = Color.black;
    public Color availableColor = Color.white;
    public Color finishedColor = Color.green;

    [Header("Images")]
    public Sprite unavailableAvatar;
    public Sprite availableAvatar;

    [Header("Texts")]
    public string unavailableName;
    public string availableName;

    [Header("Components")]
    public Image avatarImage;
    public Image backgroundImage;
    public TextMeshProUGUI textUI;
    public Button button;

    [Space]
    public int levelId = 1;

    private void Start()
    {
        bool levelFinished = Progress.lvl >= levelId;
        bool levelOpenHowIsNext = Progress.lvl == levelId - 1;

        button.enabled = levelFinished || levelOpenHowIsNext;

        avatarImage.sprite = levelOpenHowIsNext || levelFinished ? availableAvatar : unavailableAvatar;
        
        backgroundImage.color = levelFinished ? finishedColor : unavailableColor;
        backgroundImage.color = !levelFinished && levelOpenHowIsNext ? availableColor : backgroundImage.color;

        textUI.text = levelOpenHowIsNext || levelFinished ? availableName : unavailableName;
    }
}
