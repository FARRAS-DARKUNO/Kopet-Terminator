using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obj1 ;
    public GameObject obj2 ;
    bool check;
    void Start()
    {
        obj1.SetActive(true);
        obj2.SetActive(false);
        check = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            {
                obj1.SetActive(false);
                obj2.SetActive(true);
            }
    }
    private void OnTriggerEnter2D(Collider2D _box) {
        if (_box.gameObject.tag == "Player")
        {
            Renderer render = GetComponent<Renderer>();
            render.material.color = Color.yellow;
            check = true ;
        }
    }
    private void OnTriggerExit2D(Collider2D other) {

        Renderer render = GetComponent<Renderer>();
        render.material.color = Color.white;
        check = false ;
    }
}
