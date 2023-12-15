using Firebase;
using Firebase.Database;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatabaseManager : MonoBehaviour
{
    DatabaseReference reference;
    Partida partida = new Partida();
    bool controladorDespegue = false;
    bool controladorAterrizaje = false;
    public BodySourceView manos;
    // Start is called before the first frame update
    void Start()
    {
        FirebaseDatabase database = FirebaseDatabase.GetInstance("https://game-1-d2c3f-default-rtdb.firebaseio.com/");
        reference = FirebaseDatabase.DefaultInstance.RootReference;

        //GuardarPartida("0001");
    }
    public void GuardarPartida01(string partidaID)
    {
        Partida partida = new Partida(-0.3f, 0.9f);
        string json = JsonUtility.ToJson(partida);

        reference.Child(partidaID).SetRawJsonValueAsync(json);
    }
    public void GuardarPartida02(string partidaID)
    {
        Partida partida = new Partida(0f, 0.9f);
        string json = JsonUtility.ToJson(partida);

        reference.Child(partidaID).SetRawJsonValueAsync(json);
    }
    public void GuardarPartida03(string partidaID)
    {
        Partida partida = new Partida(0.3f, 0.9f);
        string json = JsonUtility.ToJson(partida);

        reference.Child(partidaID).SetRawJsonValueAsync(json);
    }
    public void GuardarPartida04(string partidaID)
    {
        Partida partida = new Partida(-0.6f, 0.6f);
        string json = JsonUtility.ToJson(partida);

        reference.Child(partidaID).SetRawJsonValueAsync(json);
    }
    public void GuardarPartida05(string partidaID)
    {
        Partida partida = new Partida(-0.3f, 0.6f);
        string json = JsonUtility.ToJson(partida);

        reference.Child(partidaID).SetRawJsonValueAsync(json);
    }
    public void GuardarPartida06(string partidaID)
    {
        Partida partida = new Partida(0f, 0.6f);
        string json = JsonUtility.ToJson(partida);

        reference.Child(partidaID).SetRawJsonValueAsync(json);
    }
    public void GuardarPartida07(string partidaID)
    {
        Partida partida = new Partida(0.3f, 0.6f);
        string json = JsonUtility.ToJson(partida);

        reference.Child(partidaID).SetRawJsonValueAsync(json);
    }
    public void GuardarPartida08(string partidaID)
    {
        Partida partida = new Partida(0.6f, 0.6f);
        string json = JsonUtility.ToJson(partida);

        reference.Child(partidaID).SetRawJsonValueAsync(json);
    }
    public void GuardarPartida09(string partidaID)
    {
        Partida partida = new Partida(-0.9f, 0.3f);
        string json = JsonUtility.ToJson(partida);

        reference.Child(partidaID).SetRawJsonValueAsync(json);
    }
    public void GuardarPartida10(string partidaID)
    {
        Partida partida = new Partida(-0.6f, 0.3f);
        string json = JsonUtility.ToJson(partida);

        reference.Child(partidaID).SetRawJsonValueAsync(json);
    }
    public void GuardarPartida11(string partidaID)
    {
        Partida partida = new Partida(0.6f, 0.3f);
        string json = JsonUtility.ToJson(partida);

        reference.Child(partidaID).SetRawJsonValueAsync(json);
    }
    public void GuardarPartida12(string partidaID)
    {
        Partida partida = new Partida(0.9f, 0.3f);
        string json = JsonUtility.ToJson(partida);

        reference.Child(partidaID).SetRawJsonValueAsync(json);
    }
    public void GuardarPartida13(string partidaID)
    {
        Partida partida = new Partida(-0.9f, 0f);
        string json = JsonUtility.ToJson(partida);

        reference.Child(partidaID).SetRawJsonValueAsync(json);
    }
    public void GuardarPartida14(string partidaID)
    {
        Partida partida = new Partida(-0.6f, 0f);
        string json = JsonUtility.ToJson(partida);

        reference.Child(partidaID).SetRawJsonValueAsync(json);
    }
    public void GuardarPartida15(string partidaID)
    {
        Partida partida = new Partida(0.6f, 0f);
        string json = JsonUtility.ToJson(partida);

        reference.Child(partidaID).SetRawJsonValueAsync(json);
    }
    public void GuardarPartida16(string partidaID)
    {
        Partida partida = new Partida(0.9f, 0f);
        string json = JsonUtility.ToJson(partida);

        reference.Child(partidaID).SetRawJsonValueAsync(json);
    }
    public void GuardarPartida17(string partidaID)
    {
        Partida partida = new Partida(-0.9f, -0.3f);
        string json = JsonUtility.ToJson(partida);

        reference.Child(partidaID).SetRawJsonValueAsync(json);
    }
    public void GuardarPartida18(string partidaID)
    {
        Partida partida = new Partida(-0.6f, -0.3f);
        string json = JsonUtility.ToJson(partida);

        reference.Child(partidaID).SetRawJsonValueAsync(json);
    }
    public void GuardarPartida19(string partidaID)
    {
        Partida partida = new Partida(0.6f, -0.3f);
        string json = JsonUtility.ToJson(partida);

        reference.Child(partidaID).SetRawJsonValueAsync(json);
    }
    public void GuardarPartida20(string partidaID)
    {
        Partida partida = new Partida(0.9f, -0.3f);
        string json = JsonUtility.ToJson(partida);

        reference.Child(partidaID).SetRawJsonValueAsync(json);
    }
    public void GuardarPartida21(string partidaID)
    {
        Partida partida = new Partida(-0.6f, -0.6f);
        string json = JsonUtility.ToJson(partida);

        reference.Child(partidaID).SetRawJsonValueAsync(json);
    }
    public void GuardarPartida22(string partidaID)
    {
        Partida partida = new Partida(-0.3f, -0.6f);
        string json = JsonUtility.ToJson(partida);

        reference.Child(partidaID).SetRawJsonValueAsync(json);
    }
    public void GuardarPartida23(string partidaID)
    {
        Partida partida = new Partida(0f, -0.6f);
        string json = JsonUtility.ToJson(partida);

        reference.Child(partidaID).SetRawJsonValueAsync(json);
    }
    public void GuardarPartida24(string partidaID)
    {
        Partida partida = new Partida(0.3f, -0.6f);
        string json = JsonUtility.ToJson(partida);

        reference.Child(partidaID).SetRawJsonValueAsync(json);
    }
    public void GuardarPartida25(string partidaID)
    {
        Partida partida = new Partida(0.6f, -0.6f);
        string json = JsonUtility.ToJson(partida);

        reference.Child(partidaID).SetRawJsonValueAsync(json);
    }
    public void GuardarPartida26(string partidaID)
    {
        Partida partida = new Partida(-0.3f, -0.9f);
        string json = JsonUtility.ToJson(partida);

        reference.Child(partidaID).SetRawJsonValueAsync(json);
    }
    public void GuardarPartida27(string partidaID)
    {
        Partida partida = new Partida(0f, -0.9f);
        string json = JsonUtility.ToJson(partida);

        reference.Child(partidaID).SetRawJsonValueAsync(json);
    }
    public void GuardarPartida28(string partidaID)
    {
        Partida partida = new Partida(0.3f, -0.9f);
        string json = JsonUtility.ToJson(partida);

        reference.Child(partidaID).SetRawJsonValueAsync(json);
    }



    //--------Movimientos para gimball y dron------------

    //TakeOff y Land
    public void takeOff(string partidaID) //Despegar
    {
        Partida partida = new Partida(0, 0, 1);
        if (controladorDespegue == false)
        {
            string json = JsonUtility.ToJson(partida);
            reference.Child(partidaID).SetRawJsonValueAsync(json);
            controladorDespegue = true;
        }
    }

    public void land(string partidaID) //Aterrizar
    {
        Partida partida = new Partida(0, 0, 2);
        if (controladorAterrizaje == false)
        {
            string json = JsonUtility.ToJson(partida);
            reference.Child(partidaID).SetRawJsonValueAsync(json);
            controladorAterrizaje = true;
        }
    }
    //Movimientos dron
    public void MoverDronX(string partidaID)
    {
        partida.ModificarDronX(1);
        string json = JsonUtility.ToJson(partida);
        reference.Child(partidaID).SetRawJsonValueAsync(json);
    }
    public void MoverDronY(string partidaID)
    {
        partida.ModificarDronY(1);
        string json = JsonUtility.ToJson(partida);
        reference.Child(partidaID).SetRawJsonValueAsync(json);
    }
    public void MoverDronZ(string partidaID)
    {
        partida.ModificarDronZ(1);
        string json = JsonUtility.ToJson(partida);
        reference.Child(partidaID).SetRawJsonValueAsync(json);
    }

    public void MoverDronXNe(string partidaID)
    {
        partida.ModificarDronXNe(1);
        string json = JsonUtility.ToJson(partida);
        reference.Child(partidaID).SetRawJsonValueAsync(json);
    }
    public void MoverDronYNe(string partidaID)
    {
        partida.ModificarDronYNe(1);
        string json = JsonUtility.ToJson(partida);
        reference.Child(partidaID).SetRawJsonValueAsync(json);
    }
    public void MoverDronZNe(string partidaID)
    {
        partida.ModificarDronZNe(1);
        string json = JsonUtility.ToJson(partida);
        reference.Child(partidaID).SetRawJsonValueAsync(json);
    }

    //Movimiento Gimball
    public void EntrarCirculoGrande(string partidaID)
    {
        partida.DentroCirculoGrande(manos.hand2Position.x, manos.hand2Position.y);
        string json = JsonUtility.ToJson(partida);
        reference.Child(partidaID).SetRawJsonValueAsync(json);
    }
    public void EntrarCirculoGrandeIzq(string partidaID)
    {
        partida.DentroCirculoGrandeIzq(manos.hand1Position.x);
        string json = JsonUtility.ToJson(partida);
        reference.Child(partidaID).SetRawJsonValueAsync(json);
    }
}

//Pitch es y, Yaw es x, Roll es z para la camara del gimball
