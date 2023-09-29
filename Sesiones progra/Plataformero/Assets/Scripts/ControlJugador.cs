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
    // Start is called before the first frame update
    void Start()
    {
        miCuerpo = GetComponent<Rigidbody2D>();
        miAnimador = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        detectarPiso();//lo primero que se hace es verificar que estè en el piso

        float velVert = miCuerpo.velocity.y;

        float movHoriz = Input.GetAxis("Horizontal");

        bool movVert = Input.GetButtonDown("Jump");

        if (movHoriz > 0)
        {//se mueve a la derechaç
            transform.rotation = Quaternion.Euler(0, 0, 0);
            miCuerpo.velocity = new Vector3(velocidadCaminar, velVert, 0);
            miAnimador.SetBool("Caminando", true);
        }
        else if (movHoriz < 0)
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
        if (movVert && numJumps > 0)
        {//se mueve hacia arriba
            
            miCuerpo.AddForce(new Vector2(0,jumpForce), ForceMode2D.Impulse);
        }

        miAnimador.SetFloat("VelocidadVertical", velVert);
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
