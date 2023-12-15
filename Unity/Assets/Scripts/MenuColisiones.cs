using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuColisiones : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Hand1")
        {
            if(gameObject.tag == "botonjugar")
            {
                Debug.Log("estoy colisionando");
                SceneManager.LoadScene(1);
            }
            else if (gameObject.tag == "botoncalibrar")
            {
               Debug.Log("estoy colisionando");
               SceneManager.LoadScene(2);
            }
            else if(gameObject.tag == "botoncreditos")
            {
                Debug.Log("estoy colisionando");
                SceneManager.LoadScene(3);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}