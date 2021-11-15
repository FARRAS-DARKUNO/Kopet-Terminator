using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class next_scane_tutorial : MonoBehaviour
{
    bool ischeck = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && ischeck)
        {
            SceneManager.LoadScene(1);
        }
    }
    private void OnMouseEnter() {
        ischeck = true ;
        Renderer render = GetComponent<Renderer>();
        render.material.color = Color.yellow;
    }
    private void OnMouseExit() {
         ischeck = false ;   
         Renderer render = GetComponent<Renderer>();
         render.material.color = Color.white;
    }
    

}
