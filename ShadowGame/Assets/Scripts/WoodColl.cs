using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodColl : MonoBehaviour
{
    public static int wood = 0;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Shadow"))
        {
            wood++;
            Destroy(gameObject);
            Debug.Log("Wood count: " + wood);
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
