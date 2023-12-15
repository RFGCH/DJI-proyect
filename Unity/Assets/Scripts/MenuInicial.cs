using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuInicial : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene(1);
    }
    public void Calibracion()
    {
        SceneManager.LoadScene(2);
    }
    public void Creditos()
    {
        SceneManager.LoadScene(3);
    }
    public void Salir()
    {
        Debug.Log("Saliendo de la app.....");
        Application.Quit();
    }
}
