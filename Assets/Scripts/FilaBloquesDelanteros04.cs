using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FilaBloquesDelanteros04 : MonoBehaviour {


    public GameObject BloqueDelantero;




    void Awake()
    {

        //////////////////////////////////////////////FILA_01/////////////////////////////////////////////////////////////////////
        //Instantiate(BloqueDelantero, new Vector3(transform.position.x, -320,BloqueDelantero.transform.position.z), Quaternion.identity);
      //  Instantiate(BloqueDelantero, new Vector3(transform.position.x, -288, BloqueDelantero.transform.position.z), Quaternion.identity);
      //  Instantiate(BloqueDelantero, new Vector3(transform.position.x, -256, BloqueDelantero.transform.position.z), Quaternion.identity);
      //  Instantiate(BloqueDelantero, new Vector3(transform.position.x, -224, BloqueDelantero.transform.position.z), Quaternion.identity);
        Instantiate(BloqueDelantero, new Vector3(transform.position.x, -192, BloqueDelantero.transform.position.z), Quaternion.identity);
        Instantiate(BloqueDelantero, new Vector3(transform.position.x, -160, BloqueDelantero.transform.position.z), Quaternion.identity);
        Instantiate(BloqueDelantero, new Vector3(transform.position.x, -128, BloqueDelantero.transform.position.z), Quaternion.identity);

        Instantiate(BloqueDelantero, new Vector3(transform.position.x, 128, BloqueDelantero.transform.position.z), Quaternion.identity);
        Instantiate(BloqueDelantero, new Vector3(transform.position.x, 160, BloqueDelantero.transform.position.z), Quaternion.identity);
        Instantiate(BloqueDelantero, new Vector3(transform.position.x, 192, BloqueDelantero.transform.position.z), Quaternion.identity);
      //  Instantiate(BloqueDelantero, new Vector3(transform.position.x, 224, BloqueDelantero.transform.position.z), Quaternion.identity);
      //  Instantiate(BloqueDelantero, new Vector3(transform.position.x, 256, BloqueDelantero.transform.position.z), Quaternion.identity);
      //  Instantiate(BloqueDelantero, new Vector3(transform.position.x, 288, BloqueDelantero.transform.position.z), Quaternion.identity);
       // Instantiate(BloqueDelantero, new Vector3(transform.position.x, 320, BloqueDelantero.transform.position.z), Quaternion.identity);

    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}
}
