using UnityEngine;

public class Tonan : MonoBehaviour
{
    // Sayacı tutacak olan değişken
    private static int ttonan = 0;

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
}
