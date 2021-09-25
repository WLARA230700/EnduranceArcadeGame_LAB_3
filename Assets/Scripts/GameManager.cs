using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager _instancia;
    public static GameManager instancia { 
        get { return _instancia; }
        //set { _instancia = value; } Esto rompe con la filosofía del patrón Singleton, ya que permitiría cambiar el valor de _instancia en cualquier otra clase.
    }

    private void Awake()
    {
        if (_instancia == null)
        {
            _instancia = this;

            //Mantiene el objeto al cambiar de escena
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void CambiarEscena(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }

    public void Salir()
    {
        Application.Quit();
    }

    public void OnApplicationQuit()
    {
        //Operaciones ante el evento de cerrar la palicación.
        //Acciones comunes: cerrar la conexión a la BD, cerrar la lectura de archivos, Guardar el progreso
    }
}
