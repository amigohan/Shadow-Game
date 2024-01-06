using UnityEngine;

public class Flowerr : MonoBehaviour
{
    // Statik olarak tanımlanan sayacı tutacak olan değişken
    public static int collectFlower = 0;

    public void OnTriggerEnter2D(Collider2D other)
    {
        // Karakter collider'ıyla çarpışma kontrolü
        if (other.CompareTag("Player"))
        {
            // Nesneyi yok et
            Destroy(gameObject);

            // Statik sayacı 1 artır
            collectFlower++;

        }
    }
}
