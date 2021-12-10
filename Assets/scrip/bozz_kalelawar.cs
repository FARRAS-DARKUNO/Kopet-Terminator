using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bozz_kalelawar : MonoBehaviour
{
    public GameObject[] nyawa;
    public GameObject[] zombies;
    public int conts;
    void Start()
    {
        
        for(int i = 0 ; i<12; i++){
            zombies[i].SetActive(false);
        }
        for(int i = 0; i<5; i++){
            nyawa[i].SetActive(true);
        }

        conts = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if (conts <= 99 && conts >= 97){
            zombies[0].SetActive(true);
        }
        if (conts == 80){
            nyawa[4].SetActive(false);
            zombies[1].SetActive(true);
            zombies[2].SetActive(true);
            zombies[3].SetActive(true);
        }
        if (conts == 60){
            nyawa[3].SetActive(false);
            zombies[4].SetActive(true);
            zombies[5].SetActive(true);
        }
        if (conts == 40){
            nyawa[2].SetActive(false);
            zombies[6].SetActive(true);
            zombies[7].SetActive(true);
            zombies[8].SetActive(true);
        }
        if (conts == 20){
            nyawa[1].SetActive(false);
            zombies[9].SetActive(true);
            zombies[10].SetActive(true);
            zombies[11].SetActive(true);
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
