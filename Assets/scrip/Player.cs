using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public AudioSource walk ;
    public AudioSource toar ;
    public AudioSource hit ;
    public AudioSource jumper ;
    public AudioSource shooter ;
    public AudioSource pic_item ;
    //////////////////////////////
    private Rigidbody2D rg ;
    public Transform point_peluru;
    public Transform point_suara;
    [SerializeField] private Transform player_game ;
    [SerializeField] private Transform respawnpoint ;
    ////////////////////////////////////////////////
    public GameObject[] item ;
    public GameObject peluru;
    public GameObject enemy;
    public GameObject suara;
    public GameObject[] life ;
    public GameObject[] hati ;
    public GameObject energi_drink;
    public GameObject madic;
    public GameObject[] energi ;
    ////////////////////////////////////////////////
    private bool isGun;
    private bool isToa;
    private float jump ;
    private float speed ;
    private float peluru_speed;
    private float suara_speed;
    private bool ismadical;
    private int minusHealth;
    private bool attackZombies;
    private bool isanmadical;
    private bool madical ;
    private bool medicah_check;
    private bool tambahnyawasatu;
    private int energi_bar;
    private int energi_conts;
    private bool isenergi ;
    private bool getegergi;
    private bool energi_check;
    private int hitung_nyawa;
  
    void Start()
    {
        
        speed = 10;
        
        
        jump = 5;
        peluru_speed = 1200;
        suara_speed  = 1200;
        
        rg = GetComponent<Rigidbody2D>();

        for (int i = 0 ; i < 4; i++){
            if (i == 0) item[i].SetActive(true);
            else item[i].SetActive(false);
        }

        for (int i =0 ; i<7 ; i++)
        {
            life[i].SetActive(true);
        }
        minusHealth = 7;

        attackZombies = false;
        ismadical =false;
        madical = false;

        for (int i = 0; i <5; i++){
            energi[i].SetActive(false);
        }
        energi_bar = 5;
        energi_conts = 0 ;


        isGun = true;
        isToa = false;
        isanmadical = false ;
        madic.SetActive(true);
        medicah_check = false ;
        energi_drink.SetActive(true);
        getegergi=false;
        energi_check = false ;
        hitung_nyawa = 0;
    }

    // Update is called once per frame
    void Update()
    {
        var move = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.A)){
            walk.Play();
        }
        transform.position += new Vector3(move,0,0) * Time.deltaTime * speed ;

       if(Input.GetButtonDown("Jump") && Mathf.Abs(rg.velocity.y) < 0.001f)
       {
           jumper.Play();
           rg.AddForce(new Vector2(0,jump),ForceMode2D.Impulse);
    
       }
       //if (attackZombies){
            //attackZombies = false ;
           // life[minusHealth].SetActive(false);
        //}

       if (Input.GetKeyDown(KeyCode.E) && ismadical){
           pic_item.Play();
           item[3].SetActive(true);
           madic.SetActive(false);
           medicah_check = true ;
       }
       if (tambahnyawasatu){
           if (minusHealth < 7){
               pic_item.Play();
               life[minusHealth].SetActive(true);
               minusHealth +=1;
               
               tambahnyawasatu = false ;
               
           }
           hati[hitung_nyawa].SetActive(false);
           hitung_nyawa +=1;
       }
       if (Input.GetKeyDown(KeyCode.E) && isenergi){
           pic_item.Play();
           item[2].SetActive(true);
           getegergi = true ;
           energi_drink.SetActive(false);
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
       if (Input.GetKeyDown(KeyCode.Alpha3) && getegergi){
           for (int i = 0; i <5; i++){
                energi[i].SetActive(true);
            }
            getegergi = false ;
            speed = 15;
            peluru_speed = 1500;
            energi_conts = 25;
            energi_check = true ;
            item[2].SetActive(false);
       }
       if (energi_check){
           if(Input.GetKeyDown(KeyCode.L)){
               energi_conts -= 1 ;
               
           }
           if(energi_conts == 20){
               energi[4].SetActive(false);
           }
           if(energi_conts == 15){
               energi[3].SetActive(false);
           }
           if(energi_conts == 10){
               energi[2].SetActive(false);
           }
           if(energi_conts == 5){
               energi[1].SetActive(false);
           }
           if(energi_conts == 0){
               energi[0].SetActive(false);
               speed = 10;
               peluru_speed = 1200;
               energi_check = false ;
           }
       }
       if(Input.GetKeyDown(KeyCode.Alpha4) && medicah_check){
           item[3].SetActive(false);
        for (int i =0 ; i<7 ; i++)
        {
            life[i].SetActive(true);
        }
        minusHealth = 7;
        medicah_check = false ;
       }

       if(Input.GetKeyDown(KeyCode.L) && isGun){
           shooter.Play();
           Shoot_Gun();
       }
       if(Input.GetKeyDown(KeyCode.L) && isToa){
           toar.Play();
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
    private void OnTriggerEnter2D(Collider2D Playertag) {
        if(Playertag.gameObject.tag == "madical"){
            ismadical = true;
        }
        if (Playertag.gameObject.tag == "enemy"){
            
            attackZombies = true ;
            if (attackZombies){
               
                if (minusHealth<=0){
                    SceneManager.LoadScene(7);
                }
                minusHealth -= 1;
                if(minusHealth>=0){
                    life[minusHealth].SetActive(false);
                    hit.Play();
                }
            }
           
        }
        if (Playertag.gameObject.tag == "hati"){
            tambahnyawasatu = true ;
        }
        if (Playertag.gameObject.tag =="dkink"){
            isenergi = true ;
        }
        if (Playertag.gameObject.tag =="Place"){
            player_game.transform.position = respawnpoint.transform.position ;
        }

    }
    private void OnTriggerExit2D(Collider2D other) {
        isanmadical = false ;
        ismadical = false;
        tambahnyawasatu =false;
        isenergi = false ;
        attackZombies = false ;
    }
}
