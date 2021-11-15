using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_iteam_off : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject off;
    bool check = false;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            off.SetActive(false);
            Time.timeScale = 1;
        }
    }
    private void OnMouseEnter() {
        check = true;
        Renderer render = GetComponent<Renderer>();
        render.material.color = Color.yellow;
    }
    private void OnMouseExit() {
        check = false ;
        Renderer render = GetComponent<Renderer>();
        render.material.color = Color.white;
    }
}
