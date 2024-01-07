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
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);

            if (uiScript != null)
            {
                uiScript.ToplananCicek++;
                Debug.Log("Toplanan �i�ek: " + uiScript.ToplananCicek);
            }
            else
            {
                Debug.LogError("uiScript bo�. Do�ru �ekilde atand���ndan emin olun.");
            }
        }
    }

    private void Update()
    {
        
    }
}
