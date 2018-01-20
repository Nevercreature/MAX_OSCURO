using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vidas : MonoBehaviour {

    public Animator animador;
    public ControladorPartida controladorPartida;

    void Start () {
		
	}
	

	void Update () {
        animador.SetInteger("Vidas", controladorPartida.vidas);
    }
}
