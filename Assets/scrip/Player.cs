using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float speed ;
    public float jump ;
    private Rigidbody2D rg ;
    void Start()
    {
        speed = 10;
        jump = 5;

        rg = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       var move = Input.GetAxis("Horizontal");
       transform.position += new Vector3(move,0,0) * Time.deltaTime * speed ;

       if(Input.GetButtonDown("Jump") && Mathf.Abs(rg.velocity.y) < 0.001f)
       {
           rg.AddForce(new Vector2(0,jump),ForceMode2D.Impulse);
    
       }
    }
}
