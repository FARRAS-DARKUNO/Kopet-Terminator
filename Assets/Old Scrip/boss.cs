using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss : MonoBehaviour
{
    public GameObject inventory ;
    public GameObject wallbozz;
    public GameObject wall_position;
    public GameObject maling;
    public GameObject maling_gitar;
    public GameObject note;
    public GameObject win;
    public float move;
    public float movei ;
    bool ismelodi = false ;
    bool check = false ;

    public GameObject fisnish;
    
        void Start()
    {
        maling_gitar.SetActive(false);
        fisnish.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (check) note.transform.position += new Vector3(movei,0,0) * Time.deltaTime * 2;

        if (Input.GetKeyDown(KeyCode.Space) && check)
        {
            note.transform.position += new Vector3(move,0,0) * Time.deltaTime *2 ;
        }

        if (note.transform.position.x >= win.transform.position.x)
        {
            maling_gitar.SetActive(false);
            fisnish.SetActive(true);
        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Player" && check == false){
            inventory.SetActive(false);

            wallbozz.transform.position = wall_position.transform.position;

            maling_gitar.SetActive(true);

            maling.SetActive(false);

            ismelodi = true ;

            check =  true ;
        }
    }
}
