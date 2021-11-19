using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    public float jump ;
    private Rigidbody2D rg ;
    private float speed ;
    public GameObject[] item ;
    private bool isGun;
    private bool isToa;
    public GameObject peluru;
    public float peluru_speed;
    public Transform point_peluru;
    public GameObject enemy;
    public GameObject suara;
    public float suara_speed;
    public Transform point_suara;
  
    void Start()
    {
        
        speed = 10;
        
        jump = 5;

        rg = GetComponent<Rigidbody2D>();

        for (int i = 0 ; i < 4; i++){
            if (i == 0) item[i].SetActive(true);
            else item[i].SetActive(false);
        }
        isGun = true;
        isToa = false;
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
       if(Input.GetKeyDown(KeyCode.Alpha1)){
           item[0].SetActive(true);
           item[1].SetActive(false);
           isGun = true;
           isToa = false;
       }
       if(Input.GetKeyDown(KeyCode.Alpha2)){
           item[0].SetActive(false);
           item[1].SetActive(true);
           isGun = false;
           isToa = true;
       }
       if(Input.GetKeyDown(KeyCode.L) && isGun){
           Shoot_Gun();
       }
       if(Input.GetKeyDown(KeyCode.L) && isToa){
           Shoot_Toa();
       }
    }
    void Shoot_Gun(){
        GameObject pelurus = Instantiate(peluru,point_peluru.position,point_peluru.rotation);
        pelurus.GetComponent<Rigidbody2D>().AddForce(peluru.transform.right * -peluru_speed);
        Destroy(pelurus,1);

    }
    void Shoot_Toa(){
        GameObject pelurus = Instantiate(suara,point_suara.position,point_suara.rotation);
        pelurus.GetComponent<Rigidbody2D>().AddForce(suara.transform.right * suara_speed);
        Destroy(pelurus,1);

    }
}
