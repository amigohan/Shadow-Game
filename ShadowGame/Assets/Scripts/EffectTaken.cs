using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public AudioSource AudioPlayer;

    void Start()
    {
    
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("InteractableObject")) // Temas etmek istediğiniz objenin etiketi
        {
            AudioPlayer.Play();
        }
    }
}
