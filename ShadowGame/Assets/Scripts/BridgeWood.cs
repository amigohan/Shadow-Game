using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeWood : MonoBehaviour
{
    [SerializeField] GameObject Obs;
    [SerializeField] GameObject Obs2;
    [SerializeField] GameObject Obs3;

    private void OnCollisionEnter2D(Collision2D other)
    {
        // WoodColl s�n�f�nda wood de�i�keni static oldu�u i�in do�rudan s�n�f ad� �zerinden eri�ilebilir.
        if (WoodColl.wood == 3)
        {
            Obs.gameObject.SetActive(true);
            Obs2.gameObject.SetActive(true);
            Obs3.gameObject.SetActive(true);
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        // WoodColl s�n�f�ndaki wood de�i�keni static oldu�u i�in art�k bir �rne�e ihtiya� yok.
    }

    // Update is called once per frame
    void Update()
    {

    }
}
