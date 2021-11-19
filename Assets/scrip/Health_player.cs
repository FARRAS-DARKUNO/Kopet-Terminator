using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_player : MonoBehaviour
{
    public GameObject[] life ;
    private int minusHealth;
    void Start()
    {
        for (int i =0 ; i<7 ; i++)
        {
            life[i].SetActive(true);
        }
        minusHealth = 7;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
