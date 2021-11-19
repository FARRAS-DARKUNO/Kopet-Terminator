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
     private bool isPlayer ;
    void Start()
    {
        speed = 2;
        movei = 1;
        isPlayer = false ;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(movei,0,0) * Time.deltaTime * -speed ;

        if (isPlayer) speed = 0;
        else speed = 2 ;

        
    }
    private void OnTriggerEnter2D(Collider2D zombies) {
        if (zombies.gameObject.tag == "Player"){
            isPlayer = true;
        }
    }
    private void OnTriggerExit2D(Collider2D zombies) {
        isPlayer = false ;
    }
    
}
