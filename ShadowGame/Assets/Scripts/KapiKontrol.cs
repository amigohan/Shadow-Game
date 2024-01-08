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
        // E�er butonun �zerindeysek kap�y� a�
        if (butonUzerinde)
        {
            kapi.SetActive(false);
            myCollider.enabled = true;
        }
        else
        {
            // Timer'� artt�r
            timer += Time.deltaTime;

            // E�er timer 3 saniyeyi ge�erse kap�y� kapat
            if (timer >= 2f)
            {
                kapiKapat();
                // Timer'� s�f�rla
                timer = 0f;
            }
        }
    }

    // Butonun �zerine giri�
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Shadow"))
        {
            butonUzerinde = true;
        }
    }

    // Butondan ��k��
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