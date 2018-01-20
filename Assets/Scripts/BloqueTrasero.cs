using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloqueTrasero : MonoBehaviour {

    public int numeroRandom;
    public Animator animador;
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
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Destructor")
        {
       
            Destroy(collision.gameObject);
        }
    }
    }
