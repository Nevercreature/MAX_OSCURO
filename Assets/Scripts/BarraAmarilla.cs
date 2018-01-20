using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarraAmarilla : MonoBehaviour {

    public ControlNaveNax controlNaveNax;
    public float escalaXDeLaBarra;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        escalaXDeLaBarra = controlNaveNax.acumulacionDisparo;

        transform.localScale = new Vector3(escalaXDeLaBarra, transform.localScale.y, transform.localScale.z);

        if (escalaXDeLaBarra >= 1) {
            escalaXDeLaBarra = 1;
        }


    }
}
