using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrupoBloquesInicial : MonoBehaviour {


    public GameObject FilaBloquesTraseros;
    public GameObject FilaBloquesDelanteros;
    public GameObject FilaBloquesDelanteros01;
    public GameObject FilaBloquesDelanteros02;
    public GameObject FilaBloquesDelanteros03;
    public GameObject FilaBloquesDelanteros04;





    void Awake()
    {

        //Filas de Bloques traseros

        Instantiate(FilaBloquesTraseros, new Vector3(-480, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(-448, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(-416, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(-384, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(-352, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(-320, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(-288, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(-256, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(-224, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(-192, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(-160, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(-128, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(-96, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(-64, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(-32, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(0, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(32, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(64, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(96, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(128, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(160, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(192, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(224, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(256, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(288, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(320, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(352, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(480, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(448, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(416, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(384, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);

        //Filas de Bloques delanteros

        Instantiate(FilaBloquesDelanteros01, new Vector3(-480, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros01, new Vector3(-448, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros01, new Vector3(-416, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros01, new Vector3(-384, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros01, new Vector3(-352, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros01, new Vector3(-320, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros01, new Vector3(-288, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros01, new Vector3(-256, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros01, new Vector3(-224, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros01, new Vector3(-192, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros01, new Vector3(-160, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros03, new Vector3(-128, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros04, new Vector3(-96, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros04, new Vector3(-64, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros04, new Vector3(-32, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros04, new Vector3(0, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros04, new Vector3(32, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros, new Vector3(64, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros, new Vector3(96, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros, new Vector3(128, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros, new Vector3(160, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros, new Vector3(192, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros, new Vector3(224, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros, new Vector3(256, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros, new Vector3(288, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros, new Vector3(320, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros, new Vector3(352, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros, new Vector3(480, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros, new Vector3(448, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros, new Vector3(416, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros, new Vector3(384, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}
}
