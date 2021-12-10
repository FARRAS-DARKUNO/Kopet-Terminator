using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kerumunan : MonoBehaviour
{
    public GameObject kerumunan;
    public GameObject [] zombies ;
    private float Kerumunan_conts ;
    private bool player;
    void Start()
    {
        kerumunan.SetActive(true);
        zombies[0].SetActive(false);
        zombies[1].SetActive(false);

        player = false ;
        Kerumunan_conts = 6;
    }

    // Update is called once per frame
    void Update()
    {
        if (player){
            Kerumunan_conts -= 1 * Time.deltaTime;
        }
        if (Kerumunan_conts <= 0f && Kerumunan_conts >= -1f){
            kerumunan.SetActive(false);
            zombies[0].SetActive(true);
            zombies[1].SetActive(true);
        }
    }
    private void OnTriggerEnter2D(Collider2D persons) {
        if (persons.gameObject.tag == "Player"){
            player = true;
        }

       
    }
    
}
