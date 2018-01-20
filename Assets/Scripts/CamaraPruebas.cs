using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraPruebas : MonoBehaviour {

    public Rigidbody2D rigidBody;

    void Awake()
    {
        rigidBody.velocity = new Vector2(1000 * Time.deltaTime, 0);
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
