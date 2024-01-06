using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Button startButton;

    private void StartTimer()
    {
        SceneManager.LoadScene(1);
    }
    
    void Start()
    {
        startButton.onClick.AddListener(StartTimer);
    }

}
