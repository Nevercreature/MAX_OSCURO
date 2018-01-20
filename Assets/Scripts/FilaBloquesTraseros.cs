using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FilaBloquesTraseros : MonoBehaviour {


    public GameObject BloqueTrasero;


    void Awake()
    {

        //////////////////////////////////////////////FILA_01/////////////////////////////////////////////////////////////////////
        //Instantiate(BloqueTrasero, new Vector3(transform.position.x, -320,BloqueTrasero.transform.position.z), Quaternion.identity);
        //Instantiate(BloqueTrasero, new Vector3(transform.position.x, -288, BloqueTrasero.transform.position.z), Quaternion.identity);
        //Instantiate(BloqueTrasero, new Vector3(transform.position.x, -256, BloqueTrasero.transform.position.z), Quaternion.identity);
        //Instantiate(BloqueTrasero, new Vector3(transform.position.x, -224, BloqueTrasero.transform.position.z), Quaternion.identity);
        //Instantiate(BloqueTrasero, new Vector3(transform.position.x, -192, BloqueTrasero.transform.position.z), Quaternion.identity);
        //Instantiate(BloqueTrasero, new Vector3(transform.position.x, -160, BloqueTrasero.transform.position.z), Quaternion.identity);
        //Instantiate(BloqueTrasero, new Vector3(transform.position.x, -128, BloqueTrasero.transform.position.z), Quaternion.identity);
        Instantiate(BloqueTrasero, new Vector3(transform.position.x, -96-16, BloqueTrasero.transform.position.z), Quaternion.identity);
        Instantiate(BloqueTrasero, new Vector3(transform.position.x, -64-16, BloqueTrasero.transform.position.z), Quaternion.identity);
      //  Instantiate(BloqueTrasero, new Vector3(transform.position.x, -32, BloqueTrasero.transform.position.z), Quaternion.identity);

      //  Instantiate(BloqueTrasero, new Vector3(transform.position.x, 0, BloqueTrasero.transform.position.z), Quaternion.identity);

      //  Instantiate(BloqueTrasero, new Vector3(transform.position.x, 32, BloqueTrasero.transform.position.z), Quaternion.identity);
        Instantiate(BloqueTrasero, new Vector3(transform.position.x, 64+16, BloqueTrasero.transform.position.z), Quaternion.identity);
        Instantiate(BloqueTrasero, new Vector3(transform.position.x, 96+16, BloqueTrasero.transform.position.z), Quaternion.identity);
       // Instantiate(BloqueTrasero, new Vector3(transform.position.x, 128, BloqueTrasero.transform.position.z), Quaternion.identity);
       // Instantiate(BloqueTrasero, new Vector3(transform.position.x, 160, BloqueTrasero.transform.position.z), Quaternion.identity);
       // Instantiate(BloqueTrasero, new Vector3(transform.position.x, 192, BloqueTrasero.transform.position.z), Quaternion.identity);
       // Instantiate(BloqueTrasero, new Vector3(transform.position.x, 224, BloqueTrasero.transform.position.z), Quaternion.identity);
        //Instantiate(BloqueTrasero, new Vector3(transform.position.x, 256, BloqueTrasero.transform.position.z), Quaternion.identity);
      //  Instantiate(BloqueTrasero, new Vector3(transform.position.x, 288, BloqueTrasero.transform.position.z), Quaternion.identity);
       // Instantiate(BloqueTrasero, new Vector3(transform.position.x, 320, BloqueTrasero.transform.position.z), Quaternion.identity);

    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


	}
}
