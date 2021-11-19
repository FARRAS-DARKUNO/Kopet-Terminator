using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_movement : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed ;
    void Start()
    {
        speed = 10;
    }

    // Update is called once per frame
    void Update()
    {
        var move = Input.GetAxis("Horizontal");
        transform.position += new Vector3(move,0,0) * Time.deltaTime * speed ;
    }
}
