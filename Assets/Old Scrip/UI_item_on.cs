using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_item_on : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ui;
    void Start()
    {
        ui.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Player")
        {
            ui.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
