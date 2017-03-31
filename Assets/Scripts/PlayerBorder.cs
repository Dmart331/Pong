using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBorder : MonoBehaviour {
    public ePlayer player;
    public ScoreUI score;
    // Use this for initialization
    private void OnCollisionEnter(Collision collision)
    {
        // Setting the ball to variable. Using this to increase the score based on the side it hit
       Ball ball = collision.gameObject.GetComponent<Ball>();
        if(ball != null)
        {
            ball.transform.position = new Vector3(0f, 1f, 0f);
            if (player == ePlayer.Right) score.scorePlayerLeft++;
            else if (player == ePlayer.Left) score.scorePlayerRight++;
        }

    }
}
