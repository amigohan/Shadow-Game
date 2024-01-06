using UnityEngine;
using UnityEngine.UI;

public class Tonan : MonoBehaviour
{
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

        void Start()
    {
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
