using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeWood : MonoBehaviour

{
    WoodColl WoodScript;
    [SerializeField] GameObject Obs;
    [SerializeField] GameObject Obs2;
    [SerializeField] GameObject Obs3;
    private void OnCollisionEnter2D(Collision2D other) {
        if (WoodScript.wood==3)
        {
            Obs.gameObject.SetActive(true);
            Obs2.gameObject.SetActive(true);
            Obs3.gameObject.SetActive(true);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        WoodScript = FindObjectOfType<WoodColl>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
