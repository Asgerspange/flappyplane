using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    private int saveValue = 1;

    private void Start()
    {
        if(PlayerPrefs.GetInt("saveValue", 0) != saveValue)
        {
            PlayerPrefs.SetInt("highScore", 0);
            PlayerPrefs.SetInt("saveValue", saveValue);
        }
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {

        Application.Quit();
 
    }
}
