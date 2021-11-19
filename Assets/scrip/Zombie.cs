using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    // Start is called before the first frame update
     private Rigidbody2D rg ;
     private float speed ;
     public float movei ;
     public GameObject player_take;
    void Start()
    {
        speed = 2;
        movei = 1;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(movei,0,0) * Time.deltaTime * -speed ;

        if (this.gameObject.tag == player_take.gameObject.tag){
            speed = 0;
        }
    }
    
}
