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
        // E�er butonun �zerindeysek kap�y� a�
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

}
