using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class FinishScript : MonoBehaviour
{
    Timer timeScript;


    void Start()
    {
        timeScript = FindObjectOfType<Timer>();
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //if (GameOverScreen != null)
            {
                //GameOverScreen.Setup((int)timeScript.timeLeft);
               // timerStarted = false;
            }
        }
    }



void Update()
    {

    }
}
