using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_player : MonoBehaviour
{
    public GameObject[] life ;
    private int minusHealth;
    private bool attackZombies;
    void Start()
    {
        for (int i =0 ; i<7 ; i++)
        {
            life[i].SetActive(true);
        }
        minusHealth = 7;

        attackZombies = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (attackZombies){
            attackZombies = false ;
            life[minusHealth].SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D playerGetDemage) {
        if (playerGetDemage.gameObject.tag == "enemy"){
            minusHealth -= 1;
            attackZombies = true ;
        }
    }
}
