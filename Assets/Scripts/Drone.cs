using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drone : MonoBehaviour {

    public Rigidbody2D rigidBody;
    public bool haciaIzquierda = true;
    public bool haciaArriba = true;
    private int velocidad = 19;
    public LayerMask Bloques;
    public float distanciaRayCasts=11.1f;
    public Animator animador;

    public GameObject explosionNormal;
    private ControladorPartida controladorPartida;

    void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        controladorPartida = GameObject.FindWithTag("GameController").GetComponent<ControladorPartida>();
    }

    void Start () {
		
	}
	

	void Update () {

        //RAYCASTS IZQUIERDA Y DERECHA, ARRIBA Y ABAJO

        if (Physics2D.Raycast(this.transform.position, Vector2.up, distanciaRayCasts, Bloques.value))
        {
            haciaArriba = false;
        }

        if (Physics2D.Raycast(this.transform.position, Vector2.down, distanciaRayCasts, Bloques.value))
        {
            haciaArriba = true;
        }

        if (Physics2D.Raycast(this.transform.position, Vector2.left, distanciaRayCasts, Bloques.value))
        {
            haciaIzquierda = false;
        }

        if (Physics2D.Raycast(this.transform.position, Vector2.right, distanciaRayCasts, Bloques.value))
        {
            haciaIzquierda = true;
        }
        //RAYCASTS DIAGONALES
        if (Physics2D.Raycast(this.transform.position, new Vector2(-1,1), distanciaRayCasts * 1.2f, Bloques.value))
        {
            haciaArriba = false;
            haciaIzquierda = false;
        }

        if (Physics2D.Raycast(this.transform.position, new Vector2(1, 1), distanciaRayCasts * 1.2f, Bloques.value))
        {
            haciaArriba = false;
            haciaIzquierda = true;
        }

        if (Physics2D.Raycast(this.transform.position, new Vector2(-1, -1), distanciaRayCasts * 1.2f, Bloques.value))
        {
            haciaArriba = true;
            haciaIzquierda = false;
        }

        if (Physics2D.Raycast(this.transform.position, new Vector2(1, -1), distanciaRayCasts *1.2f, Bloques.value))
        {
            haciaArriba = true;
            haciaIzquierda = true;
        }
        Physics2D.IgnoreLayerCollision(13, 13);   //ESTO ES PARA QUE NO SE CHOQUEN LOS BICHOS ENTRE S�
        Physics2D.IgnoreLayerCollision(13, 15);   //ESTO ES PARA QUE NO SE CHOQUEN LOS BICHOS CON LAS MONEDAS
    }

    void FixedUpdate()
    {

        if (haciaIzquierda == true)
        { 
        rigidBody.velocity = new Vector2(-velocidad, rigidBody.velocity.y);
            animador.SetInteger("Izquierda", 1);
        }
       else
        {
        rigidBody.velocity = new Vector2(velocidad, rigidBody.velocity.y);
            animador.SetInteger("Izquierda", 0);
        }

        if (haciaArriba== true)
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, velocidad);
        }
        else
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, -velocidad);
        }
        Physics2D.IgnoreLayerCollision(13, 13);   //ESTO ES PARA QUE NO SE CHOQUEN LOS BICHOS ENTRE S�
        Physics2D.IgnoreLayerCollision(13, 15);   //ESTO ES PARA QUE NO SE CHOQUEN LOS BICHOS CON LAS MONEDAS

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DisparoPotente" || collision.gameObject.tag == "DisparoPequeno")
        {
            Instantiate(explosionNormal, new Vector3(transform.position.x, transform.position.y, -2), Quaternion.identity);
            controladorPartida.dineroEnPartida = controladorPartida.dineroEnPartida + 50;
            Destroy(gameObject);
        }
    }

}
