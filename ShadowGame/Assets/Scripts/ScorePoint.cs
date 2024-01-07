using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScorePoint : MonoBehaviour
{
    Timer timerCode;
    [SerializeField] private TextMeshProUGUI scoreText;

    void Start()
    {
        timerCode = GetComponent<Timer>();
        Debug.Log(timerCode.timeLeft);
        
        scoreText.text = $"Time Left: {scoreText} seconds";
    }



    void Update()
    {
        
    }

}
