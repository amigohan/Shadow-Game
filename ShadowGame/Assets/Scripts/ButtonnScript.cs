using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonnScript : MonoBehaviour
{
    [SerializeField] GameObject ElecDoor;
    [SerializeField] GameObject ElecDoor2;
    [SerializeField] GameObject ElecDoor3;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Shadow"))
        {
            ElecDoor.gameObject.SetActive(false);
            ElecDoor2.gameObject.SetActive(true);
            ElecDoor3.gameObject.SetActive(true);
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
