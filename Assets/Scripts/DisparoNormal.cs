using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoNormal : MonoBehaviour {

    public Rigidbody2D rigidBody;
    public float velocidad = 200f;
    private int contador=0;
    public LayerMask mascaraBloque;
    public GameObject explosionPequena;

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

    void FixedUpdate()
    {

        rigidBody.velocity = new Vector2(velocidad, 0);
       // if (Physics2D.Raycast(this.transform.position, Vector2.right, 2f, mascaraBloque.value))
      //  {
       //     Instantiate(explosionPequena, new Vector3(transform.position.x, transform.position.y, -2), Quaternion.identity);
       //     Destroy(gameObject);

       // }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "BloqueDelantero")
        {

            Instantiate(explosionPequena, new Vector3(transform.position.x, transform.position.y, -2), Quaternion.identity);
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Enemigo") {
            Destroy(gameObject);
        }

    }

}
