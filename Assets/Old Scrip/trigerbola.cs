using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class trigerbola : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject item;
    public GameObject itemUI;
   
    void Start()
    {
        item.SetActive(true);
        itemUI.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D object_pic) {
        if(object_pic.gameObject.tag == "Player")
        {
            item.SetActive(false);
            itemUI.SetActive(true);
            
        }
    }
}
