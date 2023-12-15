using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    public DatabaseManager databaseManager;
    bool dentrocirculopeque = false;
    bool dentrocirculopequeiz = false;
    //public Transform mHandMesh;
    //private void Update()
    //{
    //  mHandMesh.position = Vector3.Lerp(mHandMesh.position, transform.position, Time.deltaTime * 15.0f);
    //}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "HandRight")
        {
            if (gameObject.tag == "land")
            {
                print("Aterrizar");
                databaseManager.land("0001");
            }
            else if (gameObject.tag == "MoverDronX")
            {
                databaseManager.MoverDronX("0001");
            }
            else if (gameObject.tag == "MoverDronXNe")
            {
                databaseManager.MoverDronXNe("0001");
            }
            else if (gameObject.tag == "MoverDronY")
            {
                databaseManager.MoverDronY("0001");
            }
            else if (gameObject.tag == "MoverDronYNe")
            {
                databaseManager.MoverDronYNe("0001");
            }
        }
        if (collision.gameObject.name == "HandLeft")
        {
            if (gameObject.tag == "takeOff")
            {
                print("Despegar");
                databaseManager.takeOff("0001");
            }
            //else if(gameObject.name == "MoverDronZNe")
            //else if(gameObject.tag == "MoverDronZ")
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "HandRight")
        {
            if (gameObject.tag == "circulo")
            {
                dentrocirculopeque = false;
            }
        }
        if (collision.gameObject.name == "HandLeft")
        {
            if (gameObject.tag == "circuloIzquierdo")
            {
                dentrocirculopequeiz = false;
            }
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == "HandRight")
        {
            if (gameObject.tag == "circulo")
            {
                dentrocirculopeque = true;
            }
             
            else if (gameObject.tag == "circuloGrande")
            {
                if (dentrocirculopeque == false)
                    databaseManager.EntrarCirculoGrande("0001");
            }
        }
        if (collision.gameObject.name == "HandLeft")
        {
            if (gameObject.tag == "circuloIzquierdo")
            {
                dentrocirculopequeiz = true;
            }
            else if (gameObject.tag == "circuloGrandeIzquierdo")
            {
                if (!dentrocirculopequeiz)
                    databaseManager.EntrarCirculoGrandeIzq("0001");
            }

        }
    }
}

/*
 
 */ 