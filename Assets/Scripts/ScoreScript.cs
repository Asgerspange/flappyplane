using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    [Header("Timer")]
    public float maxTime = 1;
    private float timer = 0;

    [Header("Text")]
    public TMP_Text scoreText;

    [Header("Audio")]
    public AudioSource audioSource;
    public AudioClip pointSound;

    [Header("Score")]
    public int score;

    private void Start()
    {
        PlayerPrefs.SetInt("score", 0);
    }

    private void Update()
    {
        if (timer > maxTime)
        {
            scoreText.text = score.ToString();
            PlayerPrefs.SetInt("score", score);
            score++;
            audioSource.PlayOneShot(pointSound);

            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
