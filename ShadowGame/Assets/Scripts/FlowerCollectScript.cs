using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FlowerCollectScript : MonoBehaviour
{
    Tonan uiScript;

    void Start()
    {
        uiScript = FindObjectOfType<Tonan>();


    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Shadow"))
        {
            Destroy(gameObject);

            if (uiScript != null)
            {
                uiScript.ToplananCicek++;
                Debug.Log("Toplanan Çiçek: " + uiScript.ToplananCicek);
            }
        }
    }

    private void Update()
    {
        
    }
}
