using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paused : MonoBehaviour
{
    public GameObject pause ;
    //bool check ;
    void Start()
    {
        //check = false ;
        pause.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pause.SetActive(true);
            //check = true ;
            Time.timeScale = 0;

        }
        // if (Input.GetMouseButtonDown(0) && check == true)
        // {
        //     Time.timeScale = 1;
        //     pause.SetActive(false);
        //     check = false;
        // }
        
    }
}
