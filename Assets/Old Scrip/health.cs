using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class health : MonoBehaviour
{
    public GameObject[] life ;
    public GameObject nyawa ;
    public int costlife;
    public GameObject node;
    public GameObject kalah;
    public GameObject node_posisi;
    public GameObject sound ;
    void Start()
    {
        for (int i =0 ; i<5 ; i++)
        {
            life[i].SetActive(true);
        }
        costlife = 0 ;
        sound.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (node.transform.position.x <= kalah.transform.position.x)
        {
            life[costlife].SetActive(false);
            costlife += 1;
            node.transform.position = node_posisi.transform.position;
        }
        
        if (costlife == 5) SceneManager.LoadScene(3);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "falldown")
        {
            life[costlife].SetActive(false);
            costlife ++ ;
        }
        if (other.gameObject.tag == "nyawa")
        {
            costlife = 0 ;

            for (int i =0 ; i<5 ; i++)
            {
                life[i].SetActive(true);
            }

            nyawa.SetActive(false);

            sound.SetActive(true);

        }
    }
}
