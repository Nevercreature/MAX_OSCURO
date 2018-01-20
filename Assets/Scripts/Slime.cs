using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : MonoBehaviour {

    public Animator animador;
    public LayerMask Bloques;

    public bool aIzquierda = true;
    public bool saltando;
    public Rigidbody2D rigidBody;

    public GameObject explosionNormal;
    private ControladorPartida controladorPartida;

    public float potenciaSalto = 3500;
    public Vector2 anguloDeSaltoIzquierda = new Vector2(-0.4f,1)    ;
    public Vector2 anguloDeSaltoDerecha = new Vector2(0.4f, 1);

    public int contador;

    //public static void IgnoreLayerCollision(int layer1, int layer2, bool ignore = true);

    void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        controladorPartida = GameObject.FindWithTag("GameController").GetComponent<ControladorPartida>();


    }

    void Start () {
       
    }
	

	void Update () {

        if (Physics2D.Raycast(this.transform.position, Vector2.down, 17, Bloques.value))
        {
            saltando = false;
        }
        else
        {
            saltando = true;
        }

        if (Physics2D.Raycast(this.transform.position, Vector2.left, 17, Bloques.value))
        {
            aIzquierda = false;
        }
        if (Physics2D.Raycast(this.transform.position, Vector2.right, 17, Bloques.value))
        {
            aIzquierda = true;
        }


        if (saltando == false)
        {
            animador.SetBool("Saltando", false);
        }
        else
        {
            animador.SetBool("Saltando", true);
        }

        if (aIzquierda == false)
        {
            animador.SetBool("AIzquierda", false);
        }
        else
        {
            animador.SetBool("AIzquierda", true);
        }

        if (saltando == false)
        {
            contador++;
        }
        else
        {
            contador = 0;
        }
        Physics2D.IgnoreLayerCollision(13, 13);   //ESTO ES PARA QUE NO SE CHOQUEN LOS BICHOS ENTRE S�
        Physics2D.IgnoreLayerCollision(13, 15);   //ESTO ES PARA QUE NO SE CHOQUEN LOS BICHOS CON LAS MONEDAS
    }

    void FixedUpdate()
    {



        if (contador >= 50 && aIzquierda == true && saltando == false)
        {
            rigidBody.AddForce(anguloDeSaltoIzquierda * potenciaSalto, ForceMode2D.Force);
        }

        if (contador >= 50 && aIzquierda == false && saltando == false)
        {
            rigidBody.AddForce(anguloDeSaltoDerecha * potenciaSalto, ForceMode2D.Force);
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
