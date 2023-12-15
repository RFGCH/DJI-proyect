using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Partida
{

    /*Valores maximos y minimos para el pitch, yaw y roll
        yaw: -151.8 max:8.0
        pitch: min: -89.9 max: 29.9
        roll:min: -19.9, max: 19.9 

    Pitch es x, Yaw es y, Roll es z para la camara del gimball*/
        public float x = 0.0f;
        public float y = 0.0f;
        public float z = 0.0f;
        public float pitch = 0.0f;
        public float yaw = 0.0f;
        public float roll = 0.0f;
        public float giro = 0.0f;
    public Partida(float _x = 0, float _y = 0, float _z = 0, float _pitch = 0, float _yaw = 0, float _roll = 0,float _giro=0)
        {        
            this.x = _x;
            this.y = _y;
            this.z = _z;
            this.pitch = _pitch;
            this.yaw = _yaw;
            this.roll = _roll;
            this.giro = _giro;
        }
        //Mover positivo solo una direccion Dron
        public void ModificarDronX(float _x)
        {
            this.x += _x;
            //Debug.Log("El valor de x es: " + this.x);
        }
        public void ModificarDronY(float _y)
        {
            this.y += _y;
            //Debug.Log("El valor de y es: " + this.y);
        }
        public void ModificarDronZ(float _z)
        {
            this.z += _z;
            //Debug.Log("El valor de z es: " + this.z);
        }
        //Mover negativo solo una direccion Dron
        public void ModificarDronXNe(float _x)
        {
            this.x -= _x;
            //Debug.Log("El valor de x negativo es: " + this.x);
        }
        public void ModificarDronYNe(float _y)
        {
            this.y -= _y;
            //Debug.Log("El valor de y negativo es: " + this.y);
        }
        public void ModificarDronZNe(float _z)
        {
            this.z -= _z;
            //Debug.Log("El valor de z negativo es: " + this.z);
        }
        public void DentroCirculoGrande(float manoX, float manoY)
        {
        float y = (manoX - (6.354693f - 2.5f)) / ((6.354693f + 2.5f) - (6.354693f - 2.5f));
        yaw = -80.0f + y * (80.0f - -80.0f);

        float y2 = (manoY - (-0.459f - 2.5f)) / ((-0.459f + 2.5f) - (-0.459f - 2.5f));
        pitch = -90.0f + y2 * (28.0f - -90.0f);
        }
        public void DentroCirculoGrandeIzq(float manoX)
        {
            float y2 = (manoX - (1.04f - 2.5f)) / ((1.04f + 2.5f) - (1.04f - 2.5f));
            roll = -20.0f + y2 * (20.0f - -20.0f);
        }
}

/*Valores maximos y minimos para el pitch, yaw y roll
    yaw: -151.8 max:8.0
    pitch: min: -89.9 max: 29.9
    roll:min: -19.9, max: 19.9 

Pitch es x, Yaw es y, Roll es z para la camara del gimball

*/