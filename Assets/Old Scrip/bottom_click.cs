using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bottom_click : MonoBehaviour
{
    bool check = false;
    public GameObject first ;
    public GameObject second ;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && check)
        {
            first.transform.position = second.transform.position ;
        }
    }

    private void OnMouseEnter() {
        check = true ;
        Renderer render = GetComponent<Renderer>();
        render.material.color = Color.yellow;
    }

    private void OnMouseExit() {
        check = false ;
        Renderer render = GetComponent<Renderer>();
        render.material.color = Color.white;
    }
}
