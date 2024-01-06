using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    private float timeLeft = 5.0f; // set your desired game time
    [SerializeField] private Text timerText; // reference to the UI text object

    private void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
            GameOver();

        // update the timer text on the UI
        timerText.text = $"Time Left: {timeLeft:0.00} seconds";
    }

    private void GameOver()
    {
        SceneManager.LoadScene(0); // it will reload your scene, probably this will work as a game restart for your project, you should do some better "game ending thingy" though
    }
}
