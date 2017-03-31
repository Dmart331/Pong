using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreUI : MonoBehaviour {

    public int scorePlayerRight;
    public int scorePlayerLeft;
    public GUIStyle style;
    private void OnGUI()
    {
        float x = Screen.width / 2f;
        float y = 30f;
        float width = 300f;
        float height = 20f;
        string text = scorePlayerLeft + " / " + scorePlayerRight;

        GUI.Label(new Rect(x - (width / 2f), y, width, height), text, style);
            
    }

    public void Update()
    {
        if(scorePlayerLeft == 3)
        {
            SceneManager.LoadScene("GameOver");
        }
        else if (scorePlayerRight == 3)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
