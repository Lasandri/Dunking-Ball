using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject Ball;

    public GameObject LeftHoop;
    public GameObject RightHoop;

    public int Score = 0;

    int hoopDirection = -1;     //left = -1, right = 1

    public Text ScoreText;

    private void Start()
    {
        LeftHoop.SetActive(true);
        RightHoop.SetActive(false);

        ScoreText.text = Score.ToString();
    }

    public void PlayerScored()
    {
        Score += 1;
        ScoreText.text = Score.ToString();
        ChangeDirection();
    }

    void ChangeDirection()
    {
        hoopDirection *= -1;

        if (hoopDirection == 1)
        {
            LeftHoop.SetActive(false);
            RightHoop.SetActive(true);
        } 
        else if (hoopDirection == -1)
        {
            LeftHoop.SetActive(true);
            RightHoop.SetActive(false);
        }
    }
}
