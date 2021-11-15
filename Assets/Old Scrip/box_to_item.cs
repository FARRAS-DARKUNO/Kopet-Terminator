using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box_to_item : MonoBehaviour
{
    public GameObject boxhiend ;
    public GameObject item ;
    public GameObject _e;
    bool check = false;
    void Start()
    {
        item.SetActive(false);
        _e.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (boxhiend != null && Input.GetKeyDown(KeyCode.E) && check){
            boxhiend.SetActive(false);
            item.SetActive(true);
        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Player")
        {
            check = true ;
            _e.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D other) {
        check = false ;
        _e.SetActive(false);
    }
}
