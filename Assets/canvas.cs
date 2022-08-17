using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class canvas : MonoBehaviour
{
    public TMP_Text Score;
    public float highscore;

    public Text scoretext;
    public Text highscoretext;

    public void AddScore1()
    {
        
    }
    public void MainMenuLoader()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}
