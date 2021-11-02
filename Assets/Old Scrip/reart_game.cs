using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reart_game : MonoBehaviour
{
    // Start is called before the first frame update
    public void rearty(){
        SceneManager.LoadScene(2);
    }
    public void quittomenu(){
        SceneManager.LoadScene(0);
    }
}
