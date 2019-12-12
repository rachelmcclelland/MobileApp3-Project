using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // methods for buttons
    public void OnClickPlay()
    {
        SceneManager.LoadScene("GameSceneL1");
    }

    public void OnClickHelp()
    {
        SceneManager.LoadScene("HowToScene");
    }

    public void BackToMain()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
