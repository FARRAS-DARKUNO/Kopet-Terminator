using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class People : MonoBehaviour
{
    public int cont;
    public GameObject parant;
    void Start()
    {
        cont = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (cont == 10){
            Destroy(parant);
        }
    }
    private void OnTriggerEnter2D(Collider2D persons) {
        if (persons.gameObject.tag == "suara"){
            cont ++;
        }
    }
}
