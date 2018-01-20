using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoPotente : MonoBehaviour {

    public Rigidbody2D rigidBody;
    public float velocidad = 270f;
    public LayerMask mascaraBloque;
    private int contador = 0;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
 
        transform.position = new Vector3(transform.position.x+17,transform.position.y, -0.02f);
    }

    void Start ()
    {
		
	}

    private void Update()
    {
        contador++;
        if (contador >= 200)
        {
            Destroy(gameObject);
        }
    }

    void FixedUpdate ()
    {

        rigidBody.velocity = new Vector2(velocidad, 0);

       // if (Physics2D.Raycast(this.transform.position, Vector2.right, 2f, mascaraBloque.value))
       // {
   
        //    Destroy(gameObject);

        //}
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "BloqueDelantero" || collision.gameObject.tag == "Enemigo")
        {
        

            Destroy(gameObject);
        }
    }
}
