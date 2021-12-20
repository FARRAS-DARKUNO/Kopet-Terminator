using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PROFESOR : MonoBehaviour
{
    public GameObject[] nyawa;
    public int conts;
    void Start()
    {
        for(int i = 0; i<5; i++){
            nyawa[i].SetActive(true);
        }
        conts = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if (conts == 80){
            nyawa[4].SetActive(false);
        }
        if (conts == 60){
            nyawa[3].SetActive(false);
        }
        if (conts == 40){
            nyawa[2].SetActive(false);
        }
        if (conts == 20){
            nyawa[1].SetActive(false);
        }
        if (conts == 0){
            nyawa[0].SetActive(false);
            Destroy(gameObject);
            SceneManager.LoadScene(6);
        }
    }
    private void OnTriggerEnter2D(Collider2D zombies) {
        if (zombies.gameObject.tag == "gun"){
            conts --;
        }
    }
}
