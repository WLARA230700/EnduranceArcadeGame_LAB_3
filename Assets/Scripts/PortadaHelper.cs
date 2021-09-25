using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortadaHelper : MonoBehaviour
{
    public string escenaJuego;
    public string escenaPuntaje;

    public void IniciarJuego()
    {
        try
        {
            GameManager.instancia.CambiarEscena(escenaJuego);
        }
        catch (System.Exception ex)
        {
            Debug.LogError("No se encontró el objeto GameManager en la escena: " + ex);
        }
    }

    public void VerMejoresPuntajes()
    {
        try
        {
            GameManager.instancia.CambiarEscena(escenaPuntaje);
        }
        catch (System.Exception ex)
        {
            Debug.LogError("No se encontró el objeto GameManager en la escena: " + ex);
        }
    }

    public void Salir()
    {
        try
        {
            GameManager.instancia.Salir();
        }
        catch (System.Exception ex)
        {
            Debug.LogError("Ocurrión un error al cerrar la aplicación: " + ex);
        }
    }
}
