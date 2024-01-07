using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public AudioClip collisionSound; // Ses dosyası
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = collisionSound;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("YourTag")) // Temas etmek istediğiniz objenin etiketi
        {
            audioSource.Play();
        }
    }
}
