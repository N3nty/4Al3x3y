using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public Button buttonN3nty;
    public void CloseGame()
    {
        Application.Quit();
    }
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void sverniSebeSheyu()
    {
        StartCoroutine(sverni());
    }

    IEnumerator sverni()
    {
        buttonN3nty.enabled = false;
        yield return new WaitForSeconds(14.15f);
        Application.OpenURL("https://www.youtube.com/channel/UCgL4fs7vfF_KBWRYqMaj2eQ");
        buttonN3nty.enabled = true;
    }
}
