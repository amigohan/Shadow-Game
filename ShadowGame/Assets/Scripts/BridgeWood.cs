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
        // WoodColl sýnýfýnda wood deðiþkeni static olduðu için doðrudan sýnýf adý üzerinden eriþilebilir.
        if (WoodColl.wood == 3)
        {
            Obs.gameObject.SetActive(true);
            Obs2.gameObject.SetActive(true);
            Obs3.gameObject.SetActive(true);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        // WoodColl sýnýfýndaki wood deðiþkeni static olduðu için artýk bir örneðe ihtiyaç yok.
    }

    // Update is called once per frame
    void Update()
    {

    }
}
