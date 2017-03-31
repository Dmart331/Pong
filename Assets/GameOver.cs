using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour
{

    public void RestartGame()
    {
        SceneManager.LoadScene("PingPog"); // loads current scene
    }

}
