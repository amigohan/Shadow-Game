using UnityEngine;

public class Move : MonoBehaviour
{
    public float moveSpeed = 5f;
    
    public Animator animator;


    void Update()
    {
        // Yatay ve dikey girişleri al
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        animator.setFloat("Horizontal", horizontalInput);
        animator.setFloat("Vertical", verticalInput);
        animator.setFloat("Speed", movement.sqrMagnitude);

        // Hareket vektörünü oluştur
        Vector2 movement = new Vector2(horizontalInput, verticalInput);

        // Normalleştirme ve hızı çarpma
        movement *= moveSpeed * Time.deltaTime;

        // Hareketi uygula
        transform.Translate(movement);
    }
}
