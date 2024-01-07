using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class FinishTimer : MonoBehaviour
{
    public GameOverScreen GameOverScreen;
    public float kalanZaman = 5.0f;
    [SerializeField] private TextMeshProUGUI timerText;
    bool ZamanBasla = false;
    public float BombastikZaman;

    void Start()
    {
        ZamanBasla = true;
    }

    void Update()
    {
        if (ZamanBasla == true)
        {
            kalanZaman -= Time.deltaTime;
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            BombastikZaman = kalanZaman;
            GameOverScreen.Setup((int)BombastikZaman);
            ZamanBasla = false;
            timerText.gameObject.SetActive(false);
            Debug.Log(BombastikZaman);
        }
    }
}
