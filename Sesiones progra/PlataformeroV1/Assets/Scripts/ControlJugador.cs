using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlJugador : MonoBehaviour
{
    public float velocidadCaminar = 5;
    private Rigidbody2D miCuerpo;
    private Animator miAnimador;
    public float jumpForce = 20;
    public bool enPiso = true;
    int numJumps;
    private EfectosSonoros misSonidos;
    private Personaje miPersonaje;
    // Start is called before the first frame update
    void Start()
    {
        miCuerpo = GetComponent<Rigidbody2D>();
        miAnimador = GetComponent<Animator>();
        misSonidos = GetComponent<EfectosSonoros>();
        miPersonaje = GetComponent<Personaje>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!miPersonaje.estaVivo())
        {//si estoy muerto, no se ejecuta ninguna de las siguientes acciones
            return;
        }

        detectarPiso();//lo primero que se hace es verificar que est� en el piso

        float velVert = miCuerpo.velocity.y;

        float movHoriz = Input.GetAxis("Horizontal");

        bool movVert = Input.GetButtonDown("Jump");

        bool hit = Input.GetButtonDown("Fire1");

        if (movHoriz > 0 && !miPersonaje.bloqueado)
        {//se mueve a la derecha�
            transform.rotation = Quaternion.Euler(0, 0, 0);
            miCuerpo.velocity = new Vector3(velocidadCaminar, velVert, 0);
            miAnimador.SetBool("Caminando", true);
        }
        else if (movHoriz < 0 && !miPersonaje.bloqueado)
        {// se mueve a la izquierda
            transform.rotation = Quaternion.Euler(0, 180, 0);
            miCuerpo.velocity = new Vector3(-velocidadCaminar, velVert, 0);
            miAnimador.SetBool("Caminando", true);
        }
        else
        {// no hace naa
            miCuerpo.velocity = new Vector3(0, velVert, 0);
            miAnimador.SetBool("Caminando", false);
        }
        
        if(enPiso)
        {
            numJumps = 2;
        }
        if(movVert)
        {
            numJumps = numJumps - 1;
        }
        if (movVert && numJumps > 0 && !miPersonaje.bloqueado)
        {//se mueve hacia arriba
            
            miCuerpo.AddForce(new Vector2(0,jumpForce), ForceMode2D.Impulse);
            misSonidos.reporducir("Boing");
        }

        miAnimador.SetFloat("VelocidadVertical", velVert);

        if(hit && !miPersonaje.bloqueado)
        {
            miAnimador.SetTrigger("Golpear");
        }
    }

    void detectarPiso()
    {
        enPiso = Physics2D.Raycast(
            transform.position,//origen del rayo
            Vector2.down,//direccion
            0.1f//longitud
            );


    }

}
