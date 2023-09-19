using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlJugador : MonoBehaviour
{
    public float velocidadCaminar = 5;
    private Rigidbody2D miCuerpo;
    private Animator miAnimador;
    public float jumpForce = 20;
    // Start is called before the first frame update
    void Start()
    {
        miCuerpo = GetComponent<Rigidbody2D>();
        miAnimador = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float velVert = miCuerpo.velocity.y;

        float movHoriz = Input.GetAxis("Horizontal");

        bool movVert = Input.GetButtonDown("Jump");

        if (movHoriz > 0)
        {//se mueve a la derecha�
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

        if (movVert)
        {//se mueve hacia arriba
            miCuerpo.AddForce(new Vector2(0,jumpForce), ForceMode2D.Impulse);

        }

        miAnimador.SetFloat("VelocidadVertical", velVert);
    }
}
