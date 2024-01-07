using UnityEngine;

public class SpriteChange : MonoBehaviour
{
    [SerializeField] private Sprite newSprite;
    [SerializeField] Collider2D myCollider;


    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if ((other.CompareTag("Player")) && (KeyScript.Key == 1))
        {
            ChangeSprite();
            Destroy(myCollider);
        }
    }


    private void ChangeSprite()
    {
        if (newSprite != null)
        {
            spriteRenderer.sprite = newSprite;
        }
        else
        {
            Debug.LogError("New sprite is not assigned!");
        }
    }
}
