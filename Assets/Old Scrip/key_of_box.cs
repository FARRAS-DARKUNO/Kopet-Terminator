using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key_of_box : MonoBehaviour
{   
    public GameObject key ;
    public GameObject box ;
    public GameObject box_open;
    public GameObject item;
    public GameObject e_;
    public GameObject sound ;

    bool check;
    void Start()
    {
         key.SetActive(true);
         box.SetActive(true);
         box_open.SetActive(false);
         item.SetActive(false);
         check = false;
         e_.SetActive(false);
         sound.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    { 
        if (check == true && Input.GetKeyDown(KeyCode.E)) {
            key.SetActive(false);
            box.SetActive(false);
            box_open.SetActive(true);
            sound.SetActive(true);
        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Player")
        {
            check = true ;
            e_.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D other) {
        check = false ;
        e_.SetActive(false);
    }
    
}
