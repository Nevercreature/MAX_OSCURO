using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour {
    public Rigidbody2D rigidBody;
    public Camera camera1;
   // public float camera2;

    // Use this for initialization
    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        camera1 = GetComponent<Camera>();
        camera1.orthographicSize = 135;//esto es para cambiar el tama�o de la c�mara al correcto.
    }

    void Start () {
        camera1.orthographicSize = 135;//esto es para cambiar el tama�o de la c�mara al correcto.
    }
	
	// Update is called once per frame
	void Update () {
     
        
            camera1.orthographicSize = 135; //esto es para cambiar el tama�o de la c�mara al correcto.
          

        
    }
}
