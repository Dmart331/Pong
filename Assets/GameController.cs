using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameController: MonoBehaviour { 

    public void RestartGame()
    {
        SceneManager.LoadScene("PingPog"); // loads current scene
    }

    public void StartGame()
    {
        SceneManager.LoadScene("PingPog"); // loads current scene
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
