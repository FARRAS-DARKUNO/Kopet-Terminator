using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject _enemy ;
    public GameObject text_quis ;
    void Start()
    {
        _enemy.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            _enemy.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D area) {
        if (area.gameObject.tag == "Player")
        {
            text_quis.SetActive(true);
        }
    }
}
