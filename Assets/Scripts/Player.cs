using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private Vector3 _posInicial;

    // Start is called before the first frame update
    void Start()
    {
        _posInicial = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            //Debug.Log("Enter presionado");
            transform.position = new Vector3(_posInicial.x, _posInicial.y, _posInicial.z);

            gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }

    public void Alerta()
    {
        Debug.Log("Conexión con el trigger establecida");
    }
}
