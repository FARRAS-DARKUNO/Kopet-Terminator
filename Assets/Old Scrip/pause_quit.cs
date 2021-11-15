using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause_quit : MonoBehaviour
{
   
    bool check = false;
    void Start()
    {
       
    }

    // Update is called once per frame
    public void quit_game() {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
    // void Update()
    // {
    //     if (Input.GetMouseButtonDown(0))
    //     {
    //         SceneManager.LoadScene(0);
    //         Time.timeScale = 1;
    //     }
    // }
    // private void OnMouseEnter() {
    //     check = true;
    //     Renderer render = GetComponent<Renderer>();
    //     render.material.color = Color.red;
    // }
    // private void OnMouseExit() {
    //     check = false ;
    //     Renderer render = GetComponent<Renderer>();
    //     render.material.color = Color.white;
    // }
}
