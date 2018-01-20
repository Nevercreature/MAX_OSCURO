using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionGrande : MonoBehaviour {

    public int contador;

    private void Awake()
    {
        
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        contador++;
        if (contador > 100) {
            Destroy(gameObject);
        }
	}
}
