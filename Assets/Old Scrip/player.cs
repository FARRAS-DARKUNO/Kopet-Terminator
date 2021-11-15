//using System.Threading.Tasks.Dataflow;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class player : MonoBehaviour
{
    // Start is called before the first frame update
    //trigerbola triger = new trigerbola();
    private float speed ;
    public float jump ;
    private Rigidbody2D rg ;
    public GameObject trap_ground1;
    public Animator animator;
    public GameObject akses_stop ;
    public GameObject akses_enter ;
    [SerializeField] private Transform player_game ;
    [SerializeField] private Transform respawnpoint ;
    public int item_ ;
    bool ispause = false;
    public GameObject pause;

    void Start()
    {
        speed = 10;
        jump = 23;

        rg = GetComponent<Rigidbody2D>();

        trap_ground1.SetActive(true);
        item_ = 0 ;
        akses_stop.SetActive(true);
        akses_enter.SetActive(false);
        //pause.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       animator.SetFloat("Horizontal",Input.GetAxis("Horizontal")) ;
       var move = Input.GetAxis("Horizontal");
       transform.position += new Vector3(move,0,0) * Time.deltaTime * speed ;

       if(Input.GetButtonDown("Jump") && Mathf.Abs(rg.velocity.y) < 0.001f)
       {
           rg.AddForce(new Vector2(0,jump),ForceMode2D.Impulse);
           //triger.obj1.SetActive(false);
           
       }

        if (item_ == 7)
        {
            akses_stop.SetActive(false);
            akses_enter.SetActive(true);
        }

       
    }
    private void OnTriggerEnter2D(Collider2D player_main) {
        if (player_main.gameObject.tag == "water")
        {
            speed = 3 ;
            jump = 15 ;
        }
        else {
            speed = 10;
            jump = 23 ;
        }

        if (player_main.gameObject.tag == "trap_ground")
        {
            trap_ground1.SetActive(false);
        }

        if (player_main.gameObject.tag == "falldown")
        {
            player_game.transform.position = respawnpoint.transform.position ;
        }

        if (player_main.gameObject.tag == "item_take") item_ ++ ;
    }
    private void OnTriggerExit2D(Collider2D player_main) {
        speed = 10;
        jump = 23 ;
    }
}
