using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float timeLeft = 5.0f; // set your desired game time
    [SerializeField] private TextMeshProUGUI timerText; // reference to the Text Mesh Pro object

    private void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
            GameOver();

        // update the timer text on the Text Mesh Pro object
        timerText.text = $"Time Left: {timeLeft:0.00} seconds";
    }

    private void GameOver()
    {
        SceneManager.LoadScene(0); // it will reload your scene, probably this will work as a game restart for your project, you should do some better "game ending thingy" though
    }
}
