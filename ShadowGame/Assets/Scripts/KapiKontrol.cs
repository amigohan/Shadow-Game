using UnityEngine;

public class KapiKontrol : MonoBehaviour
{
    public GameObject kapi;
    public Collider2D myCollider;


    private bool butonUzerinde;


    void Start()
    {
        butonUzerinde = false;
        
    }
    void Update()
    {
        // Eðer butonun üzerindeysek kapýyý aç
        if (butonUzerinde)
        {
            kapi.SetActive(false);
            myCollider.enabled = true;
        }
        else
        {
            kapi.SetActive(true);
            myCollider.enabled = true;
        }
    }

    // Butonun üzerine giriþ
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Shadow"))
        {
            butonUzerinde = true;
        }
    }

    // Butondan çýkýþ
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Shadow"))
        {
            butonUzerinde = false;
        }
    }

}
