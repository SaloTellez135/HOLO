using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoChikito : MonoBehaviour
{
    private Rigidbody2D miCuerpo;
    private Animator miAnimador;
    public bool cerca;
    public float velocidadCaminar = 5;

    // Start is called before the first frame update
    void Start()
    {
        miCuerpo = GetComponent<Rigidbody2D>();
        miAnimador = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (cerca)
        {
            miCuerpo.velocity = transform.right * -velocidadCaminar;
            miAnimador.SetBool("Caminando", true);
        }
        else
        {
            miCuerpo.velocity = Vector3.zero;
            miAnimador.SetBool("Caminando", false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject obj = collision.gameObject;
        if (obj.tag == "Player")
        {
            print("Jugador cerca");
            cerca = true;
            float posicionHeroe = collision.transform.position.x;
            float posicionVillano = this.transform.position.x;
            if (posicionHeroe < posicionVillano)
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);

            }
            else if(posicionHeroe > posicionVillano)
            {
                transform.rotation = Quaternion.Euler(0, 180, 0);

            }
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        GameObject obj = collision.gameObject;
        if (obj.tag == "Player")
        {
            print("Jugador lejos");
            cerca = false;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject otroObjeto = collision.gameObject;
        if (otroObjeto.tag == "Player")
        {
            print(name + "detecte colision con " + collision.gameObject);

            //Con esta instruccion se pbtiene el componente del Personaje Player
            Personaje elPerso = otroObjeto.GetComponent<Personaje>();
            //con esta instruccion se hace 20 de daño y digo quien realizo el daño
            elPerso.hacerDanio(20, gameObject);

        }
    }
}
