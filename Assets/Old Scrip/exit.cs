using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exit : MonoBehaviour
{
    bool check = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && check)
        {
            Application.Quit();
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
