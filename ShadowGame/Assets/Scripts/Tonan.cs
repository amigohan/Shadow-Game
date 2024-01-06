using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.SceneManagement;

public class Tonan : MonoBehaviour
{

    [SerializeField] private Button retryButton;
    [SerializeField] private int Sahne = 3;


    // Sayacı tutacak olan değişken
    private static int ttonan = 0;
    [SerializeField] private Image flowerImage1;
    [SerializeField] private Image flowerImage2;
    [SerializeField] private Image flowerImage3;
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Karakter collider'ıyla çarpışma kontrolü
        if (other.CompareTag("Player"))
        {
            // Nesneyi yok et
            Destroy(gameObject);

            // Sayacı 1 artır
            ttonan++;
            Debug.Log("Counter: " + ttonan); // Opsiyonel: Artışı görmek için Debug.Log kullanabilirsiniz.
        }
    }

        private void Butonabas()
    {
        SceneManager.LoadScene(Sahne);
        ttonan = 0;
    }
    

        void Start()
    {
        retryButton.onClick.AddListener(Butonabas);
        // Görünümü kapat
        if (ttonan == 0)
        {
            flowerImage1.enabled = false;
            flowerImage2.enabled = false;
            flowerImage3.enabled = false;
        }
        else if (ttonan == 1)
        {
            flowerImage1.enabled = true;
            flowerImage2.enabled = false;
            flowerImage3.enabled = false;
        }
        else if (ttonan == 2)
        {
            flowerImage1.enabled = true;
            flowerImage2.enabled = true;
            flowerImage3.enabled = false;      
        }
        else if (ttonan == 3)
        {
            flowerImage1.enabled = true;
            flowerImage2.enabled = true;
            flowerImage3.enabled = true;   
        }
    }
}
