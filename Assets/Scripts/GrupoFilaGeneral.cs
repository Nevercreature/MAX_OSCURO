using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrupoFilaGeneral : MonoBehaviour {

    

    public GameObject FilaBloquesTraseros;
    public GameObject FilaBloquesDelanteros;
    public ControladorPartida controladorPartida;
    public GameObject OtroGrupo;
    public GameObject OtraFila;
    public Camara camara;

    private bool llamadaOtraFila = false;




    void Awake()
    {

        //Filas de Bloques traseros

        Instantiate(FilaBloquesTraseros, new Vector3(transform.position.x + 0, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);

        //Filas de Bloques delanteros

        Instantiate(FilaBloquesDelanteros, new Vector3(transform.position.x + 0, FilaBloquesTraseros.transform.position.y, FilaBloquesTraseros.transform.position.z), Quaternion.identity);

    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame


    private void Update()
    {
        if (llamadaOtraFila == false && (transform.position.x - camara.transform.position.x <= 512))
        {
            LlamadaOtraFila();

        }
    }

    public void LlamadaOtraFila() {
        controladorPartida.multiplicadorGrupoBloques = controladorPartida.multiplicadorGrupoBloques + 1;
        Instantiate(OtraFila, new Vector3(transform.position.x + 32, transform.position.y, transform.position.z), Quaternion.identity);
        llamadaOtraFila = true;

    }
}
