using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectarColision : MonoBehaviour
{

    public Material materialResaltado;
    public Material materialOriginal;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Entra");
        if (other.CompareTag("Player"))
        {
            //Debug.Log("El jugador entró");

            try
            {
                var player = other.GetComponent<Player>();
                player.Alerta();

                var rigidbd = other.GetComponent<Rigidbody>();

                rigidbd.AddTorque(new Vector3(Random.Range(-1000f, 100f), Random.Range(1f, 100f), Random.Range(-1000f, 100f)));

                rigidbd.AddForce(new Vector3(Random.Range(-1000f, 1000f), Random.Range(1f, 1000f), Random.Range(-1000f, 1000f)));
            }
            catch (System.Exception e)
            {
                Debug.LogError("El objeto con la etiqueta Player no tiene agregado el componente Player: " + e);
            }

        }
    }

    private void OnTriggerStay(Collider other)
    {
        //Debug.Log("Está dentro");

        if (other.CompareTag("Player"))
        {
            gameObject.GetComponent<MeshRenderer>().material = materialResaltado;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //Debug.Log("Salió");

        if (other.CompareTag("Player"))
        {
            gameObject.GetComponent<MeshRenderer>().material = materialOriginal;
        }
    }
}
