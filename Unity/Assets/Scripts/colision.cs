using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colision : MonoBehaviour {

    public DatabaseManager databaseManager;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bubble1")
        {
            print("enter");
            databaseManager.GuardarPartida01("0001");
        }
        if (other.gameObject.tag == "Bubble2")
        {
            print("enter");
            databaseManager.GuardarPartida02("0001");
        }
        if (other.gameObject.tag == "Bubble3")
        {
            print("enter");
            databaseManager.GuardarPartida03("0001");
        }
        if (other.gameObject.tag == "Bubble4")
        {
            print("enter");
            databaseManager.GuardarPartida04("0001");
        }
        
        if (other.gameObject.tag == "Bubble5")
        {
            print("enter");
            databaseManager.GuardarPartida05("0001");
        }

        if (other.gameObject.tag == "Bubble6")
        {
            print("enter");
            databaseManager.GuardarPartida06("0001");
        }
        if (other.gameObject.tag == "Bubble7")
        {
            print("enter");
            databaseManager.GuardarPartida07("0001");
        }
        if (other.gameObject.tag == "Bubble8")
        {
            print("enter");
            databaseManager.GuardarPartida08("0001");
        }
        if (other.gameObject.tag == "Bubble9")
        {
            print("enter");
            databaseManager.GuardarPartida09("0001");
        }
        if (other.gameObject.tag == "Bubble10")
        {
            print("enter");
            databaseManager.GuardarPartida10("0001");
        }
        if (other.gameObject.tag == "Bubble11")
        {
            print("enter");
            databaseManager.GuardarPartida11("0001");
        }
        if (other.gameObject.tag == "Bubble12")
        {
            print("enter");
            databaseManager.GuardarPartida12("0001");
        }
        if (other.gameObject.tag == "Bubble13")
        {
            print("enter");
            databaseManager.GuardarPartida13("0001");
        }
        if (other.gameObject.tag == "Bubble14")
        {
            print("enter");
            databaseManager.GuardarPartida14("0001");
        }
        if (other.gameObject.tag == "Bubble15")
        {
            print("enter");
            databaseManager.GuardarPartida15("0001");
        }
        if (other.gameObject.tag == "Bubble16")
        {
            print("enter");
            databaseManager.GuardarPartida16("0001");
        }
        if (other.gameObject.tag == "Bubble17")
        {
            print("enter");
            databaseManager.GuardarPartida17("0001");
        }
        if (other.gameObject.tag == "Bubble18")
        {
            print("enter");
            databaseManager.GuardarPartida18("0001");
        }
        if (other.gameObject.tag == "Bubble19")
        {
            print("enter");
            databaseManager.GuardarPartida19("0001");
        }
        if (other.gameObject.tag == "Bubble20")
        {
            print("enter");
            databaseManager.GuardarPartida20("0001");
        }
        if (other.gameObject.tag == "Bubble21")
        {
            print("enter");
            databaseManager.GuardarPartida21("0001");
        }
        if (other.gameObject.tag == "Bubble22")
        {
            print("enter");
            databaseManager.GuardarPartida22("0001");
        }
        if (other.gameObject.tag == "Bubble23")
        {
            print("enter");
            databaseManager.GuardarPartida23("0001");
        }
        if (other.gameObject.tag == "Bubble24")
        {
            print("enter");
            databaseManager.GuardarPartida24("0001");
        }
        if (other.gameObject.tag == "Bubble25")
        {
            print("enter");
            databaseManager.GuardarPartida25("0001");
        }
        if (other.gameObject.tag == "Bubble26")
        {
            print("enter");
            databaseManager.GuardarPartida26("0001");
        }
        if (other.gameObject.tag == "Bubble27")
        {
            print("enter");
            databaseManager.GuardarPartida27("0001");
        }
        if (other.gameObject.tag == "Bubble28")
        {
            print("enter");
            databaseManager.GuardarPartida28("0001");
        }
        

        //Colisiones que hasta el momento usamos
       /* if (other.gameObject.tag == "takeOff") //Despegar
        {
            print("Despegar");
            databaseManager.takeOff("0001");
        }
        if (other.gameObject.tag == "land") //Aterrizar
        {
            print("Aterrizando");
            databaseManager.land("0001");
        }
        if (other.gameObject.tag == "MoverYaw") //Mover Yaw
        {
            print("Moviendo gimball x");
            databaseManager.MoverYaw("0001");
        }
        if (other.gameObject.tag == "MoverPitch") //Mover Pitch
        {
            print("Moviendo gimball y");
            databaseManager.MoverPitch("0001");
        }
        if (other.gameObject.tag == "MoverRoll") //Mover Roll
        {
            print("Moviendo gimball z");
            databaseManager.MoverRoll("0001");
        }
        if (other.gameObject.tag == "MoverPitchNe")
        {
            print("Moviendo gimball eje y negativo");
            databaseManager.MoverPitchNe("0001");
        }
        if (other.gameObject.tag == "MoverYawNe")
        {
            print("Moviendo gimball eje x negativo");
            databaseManager.MoverYawNe("0001");
        }
        if (other.gameObject.tag == "MoverRollNe")
        {
            print("Moviendo gimball eje y negativo");
            databaseManager.MoverRollNe("0001");
        }*/
    }
    
    //void OnTriggerExit2D(Collider2D other)
    //{
    //    if (other.gameObject.tag == "Bubble")
    //        print("exit");
    //}
}
