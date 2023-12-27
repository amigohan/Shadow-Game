using UnityEngine;

public class CharacterMimic : MonoBehaviour
{
    public Transform characterToFollow;
    private Vector3 initialOffset;

    private void Start()
    {
        // Başlangıçta karakterler arasındaki farkı kaydet
        if (characterToFollow != null)
        {
            initialOffset = transform.position - characterToFollow.position;
        }
    }

    private void Update()
    {
        // Eğer birinci karakter belirlendi ise
        if (characterToFollow != null)
        {
            // Hareket farkını al ve ikinci karaktere uygula
            Vector3 movementOffset = characterToFollow.position - (transform.position - initialOffset);
            transform.Translate(movementOffset);
        }
    }
}
