using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // methods for buttons
    public void OnClickPlay()
    {
        SceneManager.LoadScene("GameScene");
    }
}
