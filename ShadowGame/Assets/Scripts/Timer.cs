using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SocialPlatforms;

public class Timer : MonoBehaviour
{

    public GameOverScreen GameOverScreen;







    public float timeLeft = 5.0f; // set your desired game time
    [SerializeField] private TextMeshProUGUI timerText; // reference to the Text Mesh Pro object

    private bool timerStarted = false; // flag to indicate if the timer has started

    private void Start()
    {

        timerStarted = true;
        timerText.enabled = true;
    }

    private void Update()
    {
        if (timerStarted)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft <= 2.01f)
            GameOver();

            // update the timer text on the Text Mesh Pro object
            timerText.text = $"Time Left: {timeLeft:0} seconds";
        }
    }

    private void StartTimer()
    {
        timerStarted = true;
        timerText.enabled = true;
    }

    public void GameOver()
    {
        GameOverScreen.Setup((int)timeLeft);
        timerStarted = false;
    }
}