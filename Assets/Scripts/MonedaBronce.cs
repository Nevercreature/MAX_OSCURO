using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonedaBronce : MonoBehaviour {

    public Animator animador;

    private bool haCogidoLaMoneda = false;
    private ControladorPartida controladorPartida;

    public CircleCollider2D circleCollider2D;

    void Awake()
    {
        controladorPartida = GameObject.FindWithTag("GameController").GetComponent<ControladorPartida>();

        animador.SetInteger("MostrarPuntos", 0);

      

        circleCollider2D = GetComponent<CircleCollider2D>();
    }
    void Start () {
		
	}
	

	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Jugador" && haCogidoLaMoneda == false)
        {
            animador.SetInteger("MostrarPuntos", 1);

           controladorPartida.dineroEnPartida = controladorPartida.dineroEnPartida + 100;
  
            Destroy(circleCollider2D);
            haCogidoLaMoneda = true;
            Destruye();
        }
    }

    void Destruye()
    {
        Destroy(gameObject,1);
    }

}
