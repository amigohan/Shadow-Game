using UnityEngine;

public class KapiKontrol : MonoBehaviour
{
    public GameObject kapi;
    public Collider2D myCollider;

    private bool butonUzerinde;
    private float timer;

    void Start()
    {
        butonUzerinde = false;
        timer = 0f;
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
            // Timer'ý arttýr
            timer += Time.deltaTime;

            // Eðer timer 3 saniyeyi geçerse kapýyý kapat
            if (timer >= 2f)
            {
                kapiKapat();
                // Timer'ý sýfýrla
                timer = 0f;
            }
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

    void kapiKapat()
    {
        kapi.SetActive(true);
        myCollider.enabled = true;
    }
}