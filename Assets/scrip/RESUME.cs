using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RESUME : MonoBehaviour
{
    public GameObject menu ;
    void Start()
    {
        menu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        menu.SetActive(false);
        Time.timeScale = 1 ;
    }
}
