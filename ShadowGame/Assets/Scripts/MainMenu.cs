using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Button startButton;
    [SerializeField] private int myFloatValue = 3;

    private void StartTimer()
    {
        SceneManager.LoadScene(myFloatValue);
    }
    
    void Start()
    {
        startButton.onClick.AddListener(StartTimer);
    }

}
