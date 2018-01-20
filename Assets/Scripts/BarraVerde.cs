using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarraVerde : MonoBehaviour {

    public ControlNaveNax controlNaveNax;
    public float escalaXDeLaBarra;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        escalaXDeLaBarra = controlNaveNax.acumulacionDisparo;



        if (escalaXDeLaBarra >= 1) {
            escalaXDeLaBarra = 1;

            transform.localScale = new Vector3(escalaXDeLaBarra, transform.localScale.y, transform.localScale.z);
        }
        else
        {
            transform.localScale = new Vector3(0, transform.localScale.y, transform.localScale.z);
        }

    }
}
