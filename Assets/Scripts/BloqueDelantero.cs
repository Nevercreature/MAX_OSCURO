using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloqueDelantero : MonoBehaviour {

    public int numeroRandom;
    public Animator animador;
    public LayerMask mascaraDisparoPotente;
    public GameObject explosionGrande;
    public GameObject disparoPotente;






    // Use this for initialization


    void Awake()
    {
        animador = GetComponent<Animator>();
        numeroRandom = Random.Range(1, 20);
        animador.SetInteger("Disenho", numeroRandom);
    }
    void Start () {
        
       
       
    }
	
	// Update is called once per frame
	void Update () {

    


       
    }

    private void FixedUpdate()
    {

       

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DisparoPotente")
        {
            Instantiate(explosionGrande, new Vector3(transform.position.x, transform.position.y, -2), Quaternion.identity);
 
            Destroy(gameObject);
        }
    }

}
