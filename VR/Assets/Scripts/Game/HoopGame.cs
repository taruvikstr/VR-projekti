using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HoopGame : MonoBehaviour
{
    public TMP_Text scoreText;
    public int score = 0;
    public float timer = 30;
    public bool gameON = false;
    public Image filler;
    public AudioSource audioSource;
    public AudioClip gameStartSound, gameEndSound, scoreSound;

    private void Update()
    {
        if (gameON && timer > 0)
        {
            timer -= Time.deltaTime;
            filler.fillAmount = timer / 30;
        }
        else if(gameON && timer <= 0) EndGame();
    }

    public void StartGame()
    {
        audioSource.PlayOneShot(gameStartSound);
        gameON = true;
        timer = 30;
        score = 0;
        scoreText.text = score.ToString();
    }

    public void EndGame()
    {
        gameON = false;
        audioSource.PlayOneShot(gameEndSound);
    }

    public void Point()
    {
        if(gameON)
        {
            audioSource.PlayOneShot(scoreSound);
            score += 1;
            scoreText.text = score.ToString();
        }
    }
}
