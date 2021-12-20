using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paused_game : MonoBehaviour
{
    public GameObject pause ;
    void Start()
    {
        pause.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            pause.SetActive(true);
            Time.timeScale = 0 ;
        }
    }
}
