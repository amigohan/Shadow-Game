using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.SceneManagement;

public class Tonan : MonoBehaviour
{
    FinishTimer timeScript;

    public TextMeshProUGUI scoreText;

    public int ToplananCicek = 0;

    

    [SerializeField] private Image flowerImage1;
    [SerializeField] private Image flowerImage2;
    [SerializeField] private Image flowerImage3;
 

        void Start()
    {
        timeScript = FindObjectOfType<FinishTimer>();
    }


    private void Update()
    {
        float ToplamScore = ((ToplananCicek * 20) + (timeScript.BombastikZaman * 2));
        scoreText.text = $"Score: {ToplamScore:0}";

        if (ToplananCicek == 0)
        {
            flowerImage1.enabled = false;
            flowerImage2.enabled = false;
            flowerImage3.enabled = false;
        }

        else if (ToplananCicek == 1)
        {
            flowerImage1.enabled = true;
            flowerImage2.enabled = false;
            flowerImage3.enabled = false;
        }

        else if (ToplananCicek == 2)
        {
            flowerImage1.enabled = true;
            flowerImage2.enabled = true;
            flowerImage3.enabled = false;
        }

        else if (ToplananCicek == 3)
        {
            flowerImage1.enabled = true;
            flowerImage2.enabled = true;
            flowerImage3.enabled = true;
        }
    }
}
