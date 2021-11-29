using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_geting : MonoBehaviour
{
    public GameObject Eicon;
    private bool touch;
    float timer = 0;
    void Start()
    {
        Eicon.SetActive(false);
        touch = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (touch){
            Eicon.SetActive(true);
        }
        if (touch == false){
            Eicon.SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D item) {
        if (item.gameObject.tag == "Player"){
            touch = true;
        }
        
    }
    private void OnTriggerExit2D(Collider2D other) {
        touch = false ;
    }
}
