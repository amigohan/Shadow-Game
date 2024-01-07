using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodColl : MonoBehaviour
{
    public int wood = 0;
    private bool isDestroyed = false;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (!isDestroyed && (other.CompareTag("Player") || other.CompareTag("Shadow")))
        {
            wood++;
            isDestroyed = true; // Set flag to prevent multiple increments
            Destroy(gameObject);
            Debug.Log(wood);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
}
