using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float timeLeft = 5.0f; // set your desired game time
    [SerializeField] private TextMeshProUGUI timerText; // reference to the Text Mesh Pro object
    [SerializeField] private Button startButton; // reference to the Start button

    private bool timerStarted = false; // flag to indicate if the timer has started

    private void Start()
    {
        // add a listener to the Start button
        startButton.onClick.AddListener(StartTimer);
        timerText.enabled = false;
    }

    private void Update()
    {
        if (timerStarted)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft <= 0)
                GameOver();

            // update the timer text on the Text Mesh Pro object
            timerText.text = $"Time Left: {timeLeft:0.00} seconds";
        }
    }

    private void StartTimer()
    {
        timerStarted = true;
        startButton.gameObject.SetActive(false); // hide the Start button
        timerText.enabled = true;
    }

    private void GameOver()
    {
        SceneManager.LoadScene(0); // it will reload your scene, probably this will work as a game restart for your project, you should do some better "game ending thingy" though
    }
}
