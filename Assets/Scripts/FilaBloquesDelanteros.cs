using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FilaBloquesDelanteros : MonoBehaviour {


    public GameObject BloqueDelantero;
    public GameObject MonedaBronce;
    public GameObject MonedaPlata;
    public GameObject MonedaOro;
    public GameObject EnemigoDrone;
    public GameObject EnemigoSlime;

    private int Random01;
    private int Random02;
    private int Random03;
    private int Random04;
    private int Random05;
    private int Random06;
    private int Random07;



    void Awake()
    {
        Random01 = Random.Range(1, 4000);
        Random02 = Random.Range(1, 4000);
        Random03 = Random.Range(1, 4000);
        Random04 = Random.Range(1, 4000);
        Random05 = Random.Range(1, 4000);
        Random06 = Random.Range(1, 4000);
        Random07 = Random.Range(1, 4000);

        //   PARA LOS BLOQUES SOLIDOS -.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.

        //////////////////////////////////////////////FILA_01/////////////////////////////////////////////////////////////////////
        // Instantiate(BloqueDelantero, new Vector3(transform.position.x, -320,BloqueDelantero.transform.position.z), Quaternion.identity);
        //Instantiate(BloqueDelantero, new Vector3(transform.position.x, -288, BloqueDelantero.transform.position.z), Quaternion.identity);
        //Instantiate(BloqueDelantero, new Vector3(transform.position.x, -256, BloqueDelantero.transform.position.z), Quaternion.identity);
        // Instantiate(BloqueDelantero, new Vector3(transform.position.x, -224, BloqueDelantero.transform.position.z), Quaternion.identity);
        Instantiate(BloqueDelantero, new Vector3(transform.position.x, -192, BloqueDelantero.transform.position.z), Quaternion.identity);
        Instantiate(BloqueDelantero, new Vector3(transform.position.x, -160, BloqueDelantero.transform.position.z), Quaternion.identity);
        Instantiate(BloqueDelantero, new Vector3(transform.position.x, -128, BloqueDelantero.transform.position.z), Quaternion.identity);


        if (Random01 < 850){ Instantiate(BloqueDelantero, new Vector3(transform.position.x, -96, BloqueDelantero.transform.position.z), Quaternion.identity);}
        if (Random02 < 850) { Instantiate(BloqueDelantero, new Vector3(transform.position.x, -64, BloqueDelantero.transform.position.z), Quaternion.identity);}
        if (Random03 < 850) { Instantiate(BloqueDelantero, new Vector3(transform.position.x, -32, BloqueDelantero.transform.position.z), Quaternion.identity);}

        if (Random04 < 850) { Instantiate(BloqueDelantero, new Vector3(transform.position.x, 0, BloqueDelantero.transform.position.z), Quaternion.identity);}

        if (Random05 < 850) { Instantiate(BloqueDelantero, new Vector3(transform.position.x, 32, BloqueDelantero.transform.position.z), Quaternion.identity);}
        if (Random06 < 850) { Instantiate(BloqueDelantero, new Vector3(transform.position.x, 64, BloqueDelantero.transform.position.z), Quaternion.identity);}
        if (Random07 < 850) { Instantiate(BloqueDelantero, new Vector3(transform.position.x, 96, BloqueDelantero.transform.position.z), Quaternion.identity);}


        Instantiate(BloqueDelantero, new Vector3(transform.position.x, 128, BloqueDelantero.transform.position.z), Quaternion.identity);
        Instantiate(BloqueDelantero, new Vector3(transform.position.x, 160, BloqueDelantero.transform.position.z), Quaternion.identity);
        Instantiate(BloqueDelantero, new Vector3(transform.position.x, 192, BloqueDelantero.transform.position.z), Quaternion.identity);
        // Instantiate(BloqueDelantero, new Vector3(transform.position.x, 224, BloqueDelantero.transform.position.z), Quaternion.identity);
        //Instantiate(BloqueDelantero, new Vector3(transform.position.x, 256, BloqueDelantero.transform.position.z), Quaternion.identity);
        // Instantiate(BloqueDelantero, new Vector3(transform.position.x, 288, BloqueDelantero.transform.position.z), Quaternion.identity);
        // Instantiate(BloqueDelantero, new Vector3(transform.position.x, 320, BloqueDelantero.transform.position.z), Quaternion.identity);

        //   PARA LAS MONEDAS DE BRONCE-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.
        if (Random01 >= 850 && Random01 < 1000) { Instantiate(MonedaBronce, new Vector3(transform.position.x, -96, BloqueDelantero.transform.position.z), Quaternion.identity); }
        if (Random02 >= 850 && Random02 < 1000) { Instantiate(MonedaBronce, new Vector3(transform.position.x, -64, BloqueDelantero.transform.position.z), Quaternion.identity); }
        if (Random03 >= 850 && Random03 < 1000) { Instantiate(MonedaBronce, new Vector3(transform.position.x, -32, BloqueDelantero.transform.position.z), Quaternion.identity); }
        if (Random04 >= 850 && Random04 < 1000) { Instantiate(MonedaBronce, new Vector3(transform.position.x, 0, BloqueDelantero.transform.position.z), Quaternion.identity); }
        if (Random05 >= 850 && Random05 < 1000) { Instantiate(MonedaBronce, new Vector3(transform.position.x, 32, BloqueDelantero.transform.position.z), Quaternion.identity); }
        if (Random06 >= 850 && Random06 < 1000) { Instantiate(MonedaBronce, new Vector3(transform.position.x, 64, BloqueDelantero.transform.position.z), Quaternion.identity); }
        if (Random07 >= 850 && Random07 < 1000) { Instantiate(MonedaBronce, new Vector3(transform.position.x, 96, BloqueDelantero.transform.position.z), Quaternion.identity); }

        //   PARA LAS MONEDAS DE PLATA-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.
        if (Random01 >= 1000 && Random01 < 1040) { Instantiate(MonedaPlata, new Vector3(transform.position.x, -96, BloqueDelantero.transform.position.z), Quaternion.identity); }
        if (Random02 >= 1000 && Random02 < 1040) { Instantiate(MonedaPlata, new Vector3(transform.position.x, -64, BloqueDelantero.transform.position.z), Quaternion.identity); }
        if (Random03 >= 1000 && Random03 < 1040) { Instantiate(MonedaPlata, new Vector3(transform.position.x, -32, BloqueDelantero.transform.position.z), Quaternion.identity); }
        if (Random04 >= 1000 && Random04 < 1040) { Instantiate(MonedaPlata, new Vector3(transform.position.x, 0, BloqueDelantero.transform.position.z), Quaternion.identity); }
        if (Random05 >= 1000 && Random05 < 1040) { Instantiate(MonedaPlata, new Vector3(transform.position.x, 32, BloqueDelantero.transform.position.z), Quaternion.identity); }
        if (Random06 >= 1000 && Random06 < 1040) { Instantiate(MonedaPlata, new Vector3(transform.position.x, 64, BloqueDelantero.transform.position.z), Quaternion.identity); }
        if (Random07 >= 1000 && Random07 < 1040) { Instantiate(MonedaPlata, new Vector3(transform.position.x, 96, BloqueDelantero.transform.position.z), Quaternion.identity); }

        //   PARA LAS MONEDAS DE ORO-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.
        if (Random01 >= 1040 && Random01 < 1045) { Instantiate(MonedaOro, new Vector3(transform.position.x, -96, BloqueDelantero.transform.position.z), Quaternion.identity); }
        if (Random02 >= 1040 && Random02 < 1045) { Instantiate(MonedaOro, new Vector3(transform.position.x, -64, BloqueDelantero.transform.position.z), Quaternion.identity); }
        if (Random03 >= 1040 && Random03 < 1045) { Instantiate(MonedaOro, new Vector3(transform.position.x, -32, BloqueDelantero.transform.position.z), Quaternion.identity); }
        if (Random04 >= 1040 && Random04 < 1045) { Instantiate(MonedaOro, new Vector3(transform.position.x, 0, BloqueDelantero.transform.position.z), Quaternion.identity); }
        if (Random05 >= 1040 && Random05 < 1045) { Instantiate(MonedaOro, new Vector3(transform.position.x, 32, BloqueDelantero.transform.position.z), Quaternion.identity); }
        if (Random06 >= 1040 && Random06 < 1045) { Instantiate(MonedaOro, new Vector3(transform.position.x, 64, BloqueDelantero.transform.position.z), Quaternion.identity); }
        if (Random07 >= 1040 && Random07 < 1045) { Instantiate(MonedaOro, new Vector3(transform.position.x, 96, BloqueDelantero.transform.position.z), Quaternion.identity); }

        //   PARA LOS ENEMIGOS "DRONE"-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.
        if (Random01 >= 1045 && Random01 < 1085) { Instantiate(EnemigoDrone, new Vector3(transform.position.x, -91, BloqueDelantero.transform.position.z), Quaternion.identity); }
        if (Random02 >= 1045 && Random02 < 1085) { Instantiate(EnemigoDrone, new Vector3(transform.position.x, -59, BloqueDelantero.transform.position.z), Quaternion.identity); }
        if (Random03 >= 1045 && Random03 < 1085) { Instantiate(EnemigoDrone, new Vector3(transform.position.x, -27, BloqueDelantero.transform.position.z), Quaternion.identity); }
        if (Random04 >= 1045 && Random04 < 1085) { Instantiate(EnemigoDrone, new Vector3(transform.position.x, 5, BloqueDelantero.transform.position.z), Quaternion.identity); }
        if (Random05 >= 1045 && Random05 < 1085) { Instantiate(EnemigoDrone, new Vector3(transform.position.x, 37, BloqueDelantero.transform.position.z), Quaternion.identity); }
        if (Random06 >= 1045 && Random06 < 1085) { Instantiate(EnemigoDrone, new Vector3(transform.position.x, 69, BloqueDelantero.transform.position.z), Quaternion.identity); }
        if (Random07 >= 1045 && Random07 < 1085) { Instantiate(EnemigoDrone, new Vector3(transform.position.x, 96, BloqueDelantero.transform.position.z), Quaternion.identity); }
        //   PARA LOS ENEMIGOS "SLIME"-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.
        if (Random01 >= 1085 && Random01 < 1125) { Instantiate(EnemigoSlime, new Vector3(transform.position.x, -91, BloqueDelantero.transform.position.z), Quaternion.identity); }
        if (Random02 >= 1085 && Random02 < 1125) { Instantiate(EnemigoSlime, new Vector3(transform.position.x, -59, BloqueDelantero.transform.position.z), Quaternion.identity); }
        if (Random03 >= 1085 && Random03 < 1125) { Instantiate(EnemigoSlime, new Vector3(transform.position.x, -27, BloqueDelantero.transform.position.z), Quaternion.identity); }
        if (Random04 >= 1085 && Random04 < 1125) { Instantiate(EnemigoSlime, new Vector3(transform.position.x, 5, BloqueDelantero.transform.position.z), Quaternion.identity); }
        if (Random05 >= 1085 && Random05 < 1125) { Instantiate(EnemigoSlime, new Vector3(transform.position.x, 37, BloqueDelantero.transform.position.z), Quaternion.identity); }
        if (Random06 >= 1085 && Random06 < 1125) { Instantiate(EnemigoSlime, new Vector3(transform.position.x, 69, BloqueDelantero.transform.position.z), Quaternion.identity); }
        if (Random07 >= 1085 && Random07 < 1125) { Instantiate(EnemigoSlime, new Vector3(transform.position.x, 96, BloqueDelantero.transform.position.z), Quaternion.identity); }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}
}
