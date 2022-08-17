using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScore : MonoBehaviour
{
    [Header("Text")]
    [SerializeField] private TextMeshProUGUI score;
    [SerializeField] private TextMeshProUGUI highScore;

    private void Start()
    {
        score.text = PlayerPrefs.GetInt("score").ToString();

        if(PlayerPrefs.GetInt("highScore", 0) < PlayerPrefs.GetInt("score"))
        {
            PlayerPrefs.SetInt("highScore", PlayerPrefs.GetInt("score"));
        }

        highScore.text = PlayerPrefs.GetInt("highScore").ToString();

    }

}
