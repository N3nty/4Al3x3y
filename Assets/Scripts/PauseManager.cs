using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour
{
    [SerializeField] private GameObject restartPanel;
    [SerializeField] private GameObject nextLevelPanel;

    public void RestartGame()
    {
        restartPanel.SetActive(true);
    }
    public void NextLevel()
    {
        nextLevelPanel.SetActive(true);
    }
}
