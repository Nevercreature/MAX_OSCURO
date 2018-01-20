using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrupoBloquesGeneral : MonoBehaviour {

    

    public GameObject FilaBloquesTraseros;
    public GameObject FilaBloquesDelanteros;
    public ControladorPartida controladorPartida;
    public GameObject OtroGrupo;
    public GameObject OtraFila;
    public Camara camara;

   // private bool llamadaOtroGrupo = false;           // esto ya no se usa




    void Awake()
    {

        //Filas de Bloques traseros

        Instantiate(FilaBloquesTraseros, new Vector3(transform.position.x -480, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(transform.position.x - 448, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(transform.position.x - 416, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(transform.position.x - 384, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(transform.position.x - 352, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(transform.position.x - 320, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(transform.position.x - 288, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(transform.position.x - 256, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(transform.position.x - 224, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(transform.position.x - 192, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(transform.position.x - 160, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(transform.position.x - 128, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(transform.position.x - 96, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(transform.position.x - 64, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(transform.position.x - 32, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(transform.position.x + 0, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(transform.position.x + 32, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(transform.position.x + 64, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(transform.position.x + 96, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(transform.position.x + 128, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(transform.position.x + 160, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(transform.position.x + 192, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(transform.position.x + 224, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(transform.position.x + 256, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(transform.position.x + 288, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(transform.position.x + 320, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(transform.position.x + 352, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(transform.position.x + 480, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(transform.position.x + 448, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(transform.position.x + 416, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesTraseros, new Vector3(transform.position.x + 384, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);

        //Filas de Bloques delanteros

        Instantiate(FilaBloquesDelanteros, new Vector3(transform.position.x - 480, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros, new Vector3(transform.position.x - 448, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros, new Vector3(transform.position.x - 416, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros, new Vector3(transform.position.x - 384, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros, new Vector3(transform.position.x - 352, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros, new Vector3(transform.position.x - 320, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros, new Vector3(transform.position.x - 288, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros, new Vector3(transform.position.x - 256, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros, new Vector3(transform.position.x - 224, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros, new Vector3(transform.position.x - 192, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros, new Vector3(transform.position.x - 160, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros, new Vector3(transform.position.x - 128, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros, new Vector3(transform.position.x - 96, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros, new Vector3(transform.position.x - 64, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros, new Vector3(transform.position.x - 32, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros, new Vector3(transform.position.x + 0, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros, new Vector3(transform.position.x + 32, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros, new Vector3(transform.position.x + 64, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros, new Vector3(transform.position.x + 96, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros, new Vector3(transform.position.x + 128, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros, new Vector3(transform.position.x + 160, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros, new Vector3(transform.position.x + 192, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros, new Vector3(transform.position.x + 224, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros, new Vector3(transform.position.x + 256, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros, new Vector3(transform.position.x + 288, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros, new Vector3(transform.position.x + 320, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros, new Vector3(transform.position.x + 352, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros, new Vector3(transform.position.x + 480, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros, new Vector3(transform.position.x + 448, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros, new Vector3(transform.position.x + 416, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
        Instantiate(FilaBloquesDelanteros, new Vector3(transform.position.x + 384, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame


    private void Update()
    {
     //   if (llamadaOtroGrupo == false && (transform.position.x - camara.transform.position.x <= 0))
     //   {
     //       LlamadaOtroBloque();
     //
     //  }
    }

   // public void LlamadaOtroBloque() {
   //     controladorPartida.multiplicadorGrupoBloques = controladorPartida.multiplicadorGrupoBloques + 1;
   //     Instantiate(OtraFila, new Vector3(controladorPartida.multiplicadorGrupoBloques * 512, transform.position.y, transform.position.z), Quaternion.identity);
   //     llamadaOtroGrupo = true;
   //
   //}
}
