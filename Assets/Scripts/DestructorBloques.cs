using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructorBloques : MonoBehaviour {

    public ControladorPartida controladorPartida;

    private void Awake()
    {

    }


    void Start() {

    }


    void Update() {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "FilaBloquesTraseros")
        {
            controladorPartida.distanciarecorrida = controladorPartida.distanciarecorrida + 1;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag != "FilaBloquesTraseros" && collision.gameObject.tag != "Jugador")
        {

            Destroy(collision.gameObject);
        }
    }





}

    
    
