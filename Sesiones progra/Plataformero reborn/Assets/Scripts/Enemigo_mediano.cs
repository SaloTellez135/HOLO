using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo_mediano : MonoBehaviour

{
    public float velocidadCaminar = 3f;
    public float distanciaAgro = 5;
    public float distanciaAgroCorta = 3;
    private GameObject heroe;
    private Rigidbody2D miCuerpo;
    private Animator miAnimador;
    public int puntosDanio = 10;
    public GameObject efectoGolpePrefab;
    private Personaje miPersonaje;

    void Start()
    {
        miPersonaje = GetComponent<Personaje>();
        heroe = GameObject.FindWithTag("Player");
        miCuerpo = GetComponent<Rigidbody2D>();
        miAnimador = GetComponent<Animator>();
    }

    void Update()
    {
        Vector3 posHeroe = heroe.transform.position;
        Vector3 posYo = this.transform.position;

        float distancia = (posYo - posHeroe).magnitude;
        float velActualVert = miCuerpo.velocity.y;

        if (distancia < distanciaAgro && distancia > distanciaAgroCorta && !miPersonaje.aturdido && !miPersonaje.muerto)
        {//El heroe esta fuera de la zona de agro
            if(posHeroe.x > posYo.x)
            {//El heroe derecha villando
                transform.rotation = Quaternion.Euler(0, 0, 0);
                miCuerpo.velocity = new Vector3(velocidadCaminar, velActualVert, 0);
                miAnimador.SetBool("caminando", true);
                miAnimador.SetBool("atacando", false);
            }
            else
            {//El heroe izquierda villando
                transform.rotation = Quaternion.Euler(0, 180, 0);
                miCuerpo.velocity = new Vector3(-velocidadCaminar, velActualVert, 0);
                miAnimador.SetBool("caminando", true);
                miAnimador.SetBool("atacando", false);
            }
        }
        else if (distancia < distanciaAgro && distancia < distanciaAgroCorta && !miPersonaje.aturdido && !miPersonaje.muerto)
        {
            if (posHeroe.x > posYo.x)
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
                miCuerpo.velocity = new Vector3(0, 0, 0);
                miAnimador.SetBool("atacando", true);
                miAnimador.SetBool("caminando", false);
            }
            else
            {
                transform.rotation = Quaternion.Euler(0, 180, 0);
                miCuerpo.velocity = new Vector3(0, 0, 0);
                miAnimador.SetBool("atacando", true);
                miAnimador.SetBool("caminando", false);
            }
        }
        else
        {//El heroe esta fuera de la zona de agro
            transform.rotation = Quaternion.Euler(0, 0, 0);
            miCuerpo.velocity = new Vector3(0, 0, 0);
            miAnimador.SetBool("atacando", false);
            miAnimador.SetBool("caminando", false);
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(name + "hizo colision con" + collision.gameObject.name);
        GameObject otro = collision.gameObject;
        if (otro.tag == "Player")
        {
            //Accede al componente de tipo Personaje del objeto con el que choquè
            Personaje elPerso = otro.GetComponent<Personaje>();
            //Aplico el daño al otro invocando el metodo hacer daño
            elPerso.hacerDanio(puntosDanio, this.gameObject);
            GameObject golpe = Instantiate(efectoGolpePrefab, elPerso.transform);
        }
    }
}

