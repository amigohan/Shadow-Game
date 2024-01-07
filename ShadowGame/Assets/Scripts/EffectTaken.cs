using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public AudioSource AudioPlayer;
    public AudioSource AudioPlayerr;

    void Start()
    {
    
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("InteractableObject")) // Temas etmek istediğiniz objenin etiketi
        {
            AudioPlayer.Play();
        }

        if (collision.gameObject.CompareTag("Key"))
        {
            AudioPlayerr.Play();
        }
    }
}
