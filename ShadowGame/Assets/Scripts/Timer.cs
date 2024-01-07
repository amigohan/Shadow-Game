using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SocialPlatforms;
using System.Xml;

public class Timer : MonoBehaviour
{

    public GameOverScreen GameOverScreen;


    public float timeLeft = 5.0f;
    [SerializeField] private TextMeshProUGUI timerText;

    bool timerStarted = false;

    private void Start()
    {

        timerStarted = true;
        timerText.enabled = true;
    }

    private void Update()
    {
        if (timerStarted == true)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft <= 0)
            GameOver();

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
        timerText.gameObject.SetActive(false);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {      
            GameOver();   
        }
    }

}