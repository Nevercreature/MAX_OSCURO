using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine;

public class ControlNaveNax : MonoBehaviour {


    public Rigidbody2D rigidBody;
    public Animator animador;

    public GameObject DisparoNormal;
    public GameObject DisparoPotente;
    public ControladorPartida controladorPartida;
    public Transform NacimientoDelDisparo;

    public float acumulacionDisparo;

    public float MueveHorizontal;
    public float MueveVertical;

    public bool golpeado=false;
    public float contadorGolpeado=0;

    public GameObject ExplosionGrande;
    public SpriteRenderer spriteRender;

    public Material rojo;
    public Material normal;


    //estadoAnimacion = 1 IDLE
    //estadoAnimacion = 2 SUBIENDO
    //estadoAnimacion = 3 BAJANDO


    void Awake() {
        controladorPartida.vidas = 5;
        rigidBody = GetComponent<Rigidbody2D>();
        animador = GetComponent<Animator>();
        spriteRender = GetComponent<SpriteRenderer>();
        //  naveControlable = false;
    }

    void Start() {

    }

    void FixedUpdate() {
       

            

            if (controladorPartida.naveControlable == false && transform.position.x < -64 && controladorPartida.vidas > 0)
            {

                rigidBody.velocity = new Vector2(controladorPartida.velocidadMovimiento, 0);
            }
            else
            {
                controladorPartida.naveControlable = true;
            }
            //// Vertical ////////////////////////////////////////////////////////////////////////////////////////////

            if (controladorPartida.naveControlable == true)
            {

            rigidBody.velocity = new Vector2(controladorPartida.velocidadMovimiento, rigidBody.velocity.y);

            if (MueveVertical <0.23f && MueveVertical > -0.23f) //            if (MueveVertical <= 0.3f && MueveVertical > -0.3f)
            {
                animador.SetInteger("estadoAnimacion", 1);
                rigidBody.velocity = new Vector2(rigidBody.velocity.x, 0);
            }




            if (MueveVertical > 0.23f)
            {

                animador.SetInteger("estadoAnimacion", 2);
                rigidBody.velocity = new Vector2(rigidBody.velocity.x, controladorPartida.velocidadMovimiento * 1.55f * MueveVertical);
            }


            if (MueveVertical < -0.23f) //if (MueveVertical < -0.3)
            {

                animador.SetInteger("estadoAnimacion", 3);
                rigidBody.velocity = new Vector2(rigidBody.velocity.x, controladorPartida.velocidadMovimiento * 1.55f * MueveVertical);
            }


            //// Horizontal ////////////////////////////////////////////////////////////////////////////////////////////

            if (MueveHorizontal < -0.23f)
            {

                rigidBody.velocity = new Vector2(controladorPartida.velocidadMovimiento * 2.15f * MueveHorizontal, rigidBody.velocity.y);
           
         
            }

            if (MueveHorizontal > 0.23f)  // if (MueveHorizontal > 0.3f) 
            {

                rigidBody.velocity = new Vector2(controladorPartida.velocidadMovimiento * 2.9f * MueveHorizontal, rigidBody.velocity.y);
            }

            MueveHorizontal = CrossPlatformInputManager.GetAxis("Horizontal");
            MueveVertical = CrossPlatformInputManager.GetAxis("Vertical");



            if (controladorPartida.naveControlable == true && CrossPlatformInputManager.GetButton("Fire1"))
            {
                acumulacionDisparo = acumulacionDisparo + 0.017f;
            }

            if (acumulacionDisparo > 1)
            {
                acumulacionDisparo = 1;
            }

        }
        if (golpeado == true && contadorGolpeado < 120)
        {
            contadorGolpeado = contadorGolpeado + 1;
            CambioColor();

        }
        else
        {
            contadorGolpeado = 0;
            golpeado = false;

        }
    }

    private void Update()
    {

        if (controladorPartida.naveControlable == true)                                    //Esto es de prueba
        {
            if (CrossPlatformInputManager.GetButtonUp("Fire1") && acumulacionDisparo >= 0 && acumulacionDisparo < 1)
            {
                Instantiate(DisparoNormal, NacimientoDelDisparo.position, Quaternion.identity);
                acumulacionDisparo = 0;
            }
            if (CrossPlatformInputManager.GetButtonUp("Fire1") && acumulacionDisparo >= 1)
            {
                Instantiate(DisparoPotente, NacimientoDelDisparo.position, Quaternion.identity);
                acumulacionDisparo = 0;
            }
        }

        if (controladorPartida.vidas <= 0)                            // Esto es para que cuando se pierdan todas las vidas la nave explote
        {
            controladorPartida.naveControlable = false;
           Destroy(gameObject);
            Instantiate(ExplosionGrande, transform.position, Quaternion.identity);
        }
        // PARA LOS GOLPES






    }

    void OnCollisionEnter2D(Collision2D collision)  //esto es para la colision con los enemigos
    {
        if (collision.gameObject.tag == "Enemigo" && golpeado == false)
        {
            controladorPartida.vidas--;
            golpeado = true;
        }
    }

    void CambioColor()
    {
        if (contadorGolpeado > 0 && contadorGolpeado <= 4) { spriteRender.material = rojo; }
        if (contadorGolpeado > 4 && contadorGolpeado <= 8) { spriteRender.material = normal; }
        if (contadorGolpeado > 8 && contadorGolpeado <= 12) { spriteRender.material = rojo; }
        if (contadorGolpeado > 12 && contadorGolpeado <= 16) { spriteRender.material = normal; }
        if (contadorGolpeado > 16 && contadorGolpeado <= 20) { spriteRender.material = rojo; }
        if (contadorGolpeado > 20 && contadorGolpeado <= 24) { spriteRender.material = normal; }
        if (contadorGolpeado > 24 && contadorGolpeado <= 28) { spriteRender.material = rojo; }
        if (contadorGolpeado > 28 && contadorGolpeado <= 32) { spriteRender.material = normal; }
        if (contadorGolpeado > 32 && contadorGolpeado <= 36) { spriteRender.material = rojo; }
        if (contadorGolpeado > 36 && contadorGolpeado <= 40) { spriteRender.material = normal; }
        if (contadorGolpeado > 40 && contadorGolpeado <= 44) { spriteRender.material = rojo; }
        if (contadorGolpeado > 44 && contadorGolpeado <= 48) { spriteRender.material = normal; }
        if (contadorGolpeado > 48 && contadorGolpeado <= 52) { spriteRender.material = rojo; }
        if (contadorGolpeado > 52 && contadorGolpeado <= 56) { spriteRender.material = normal; }
        if (contadorGolpeado > 56 && contadorGolpeado <= 60) { spriteRender.material = rojo; }

        if (contadorGolpeado > 60 && contadorGolpeado <= 64) { spriteRender.material = normal; }
        if (contadorGolpeado > 64 && contadorGolpeado <= 68) { spriteRender.material = rojo; }
        if (contadorGolpeado > 68 && contadorGolpeado <= 72) { spriteRender.material = normal; }
        if (contadorGolpeado > 72 && contadorGolpeado <= 76) { spriteRender.material = rojo; }
        if (contadorGolpeado > 76 && contadorGolpeado <= 80) { spriteRender.material = normal; }
        if (contadorGolpeado > 80 && contadorGolpeado <= 84) { spriteRender.material = rojo; }
        if (contadorGolpeado > 84 && contadorGolpeado <= 88) { spriteRender.material = normal; }
        if (contadorGolpeado > 88 && contadorGolpeado <= 92) { spriteRender.material = rojo; }
        if (contadorGolpeado > 92 && contadorGolpeado <= 96) { spriteRender.material = normal; }
        if (contadorGolpeado > 96 && contadorGolpeado <= 100) { spriteRender.material = rojo; }
        if (contadorGolpeado > 100 && contadorGolpeado <= 104) { spriteRender.material = normal; }
        if (contadorGolpeado > 104 && contadorGolpeado <= 108) { spriteRender.material = rojo; }
        if (contadorGolpeado > 100 && contadorGolpeado <= 104) { spriteRender.material = normal; }
        if (contadorGolpeado > 104 && contadorGolpeado <= 108) { spriteRender.material = rojo; }
        if (contadorGolpeado > 108 && contadorGolpeado <= 112) { spriteRender.material = normal; }
        if (contadorGolpeado > 112 && contadorGolpeado <= 116) { spriteRender.material = normal; }
        if (contadorGolpeado > 120 || contadorGolpeado == 0) { spriteRender.material = normal; }
    }
}

