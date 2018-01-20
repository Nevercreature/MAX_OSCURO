using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorPartida : MonoBehaviour {

    public ControlNaveNax controlNaveNax;
    public float velocidadMovimiento = 40f;
    public Camara camara;

    public bool naveControlable = false;
    public float multiplicadorGrupoBloques = 1;

    public int dineroEnPartida;
    public int vidas=5;
    public int distanciarecorrida;

    public Text distanciarecorridaTexto;
    public Text scoreTexto;                              // ESTO HAY QUE CAMBIARLO A LOS PUNTOS
    public int contadorTilt=1000;
    public bool detonanteTilt = false;

    public float tiempo;

    void Awake()
    {
        distanciarecorridaTexto.text =""+ distanciarecorrida;
        dineroEnPartida = 0;
    }

    void Start () {
		
	}

    private void FixedUpdate()
    {


        if (naveControlable == true)
        {
            camara.rigidBody.velocity = new Vector2(velocidadMovimiento, 0);
          
        }

        // ESTO ANTES ESTABA EN EL UPDATE Y AHORA SE HA PASADO A LA NAVENAX
        /*
       if (naveControlable == false && controlNaveNax.transform.position.x < -64 && vidas > 0)
       {

           controlNaveNax.rigidBody.velocity = new Vector2(velocidadMovimiento, 0);
       }
       else
       {
           naveControlable = true;
       }
       */


    }

    void Update () {



        distanciarecorridaTexto.text = "" + distanciarecorrida;
       scoreTexto.text = "" + dineroEnPartida;

        if (dineroEnPartida >= 999999999) {
            dineroEnPartida = 999999999;
        }
        if (distanciarecorrida >= 9999999)
        {
            distanciarecorrida = 9999999;
        }


        tiempo = Time.deltaTime;

        //CUANDO GOLPEAN LA NAVE la CAMARA VIBRA EN "Y"

        if (controlNaveNax.golpeado == true && controlNaveNax.contadorGolpeado==0)
        {
            contadorTilt=0;
  
        }

    
            contadorTilt ++;

        if (contadorTilt>=0 && contadorTilt < 2)
        {
            camara.transform.position = new Vector3(camara.transform.position.x, -12 , camara.transform.position.z);
        }
        if (contadorTilt >= 2 && contadorTilt < 4)
        {
            camara.transform.position = new Vector3(camara.transform.position.x, -8, camara.transform.position.z);
        }
        if (contadorTilt >= 4 && contadorTilt < 6)
        {
            camara.transform.position = new Vector3(camara.transform.position.x, -12, camara.transform.position.z);
        }
        if (contadorTilt >= 6 && contadorTilt < 8)
        {
            camara.transform.position = new Vector3(camara.transform.position.x, -8, camara.transform.position.z);
        }
        if (contadorTilt >= 8 && contadorTilt < 10)
        {
            camara.transform.position = new Vector3(camara.transform.position.x, -11, camara.transform.position.z);
        }
        if (contadorTilt >= 10 && contadorTilt < 12)
        {
            camara.transform.position = new Vector3(camara.transform.position.x, -9, camara.transform.position.z);
        }
        if (contadorTilt >= 12 && contadorTilt < 14)
        {
            camara.transform.position = new Vector3(camara.transform.position.x, -11, camara.transform.position.z);
        }
        if (contadorTilt >= 14 && contadorTilt < 16)
        {
            camara.transform.position = new Vector3(camara.transform.position.x, -9, camara.transform.position.z);
        }
        if (contadorTilt >= 16)
        {
            camara.transform.position = new Vector3(camara.transform.position.x, -10, camara.transform.position.z);
        }

    }
}
