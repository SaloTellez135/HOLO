using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoGlande : MonoBehaviour
{
    private Rigidbody2D miCuerpo;
    private Animator miAnimador;
    private GameObject heroeJugador;
    private EfectosSonoros misSonidos;
    public GameObject splashBloodPrefab;
    public bool cerca;
    public float velocidadCaminar = 5;
    public int puntosDanio = 15;
    public float rangoAgro = 4;
    public float rangoAtk = 2;
    // Start is called before the first frame update
    void Start()
    {
        miCuerpo = GetComponent<Rigidbody2D>();
        miAnimador = GetComponent<Animator>();
        heroeJugador = GameObject.FindGameObjectWithTag("Player");
        misSonidos = GetComponent<EfectosSonoros>();
    }

    // Update is called once per frame
    void Update()
    {
        bool enemigoVivo = this.GetComponent<Personaje>().estaVivo();
        bool heroeVivo = heroeJugador.GetComponent<Personaje>().estaVivo();
        Vector3 miPos = this.transform.position;
        Vector3 posHeroe = heroeJugador.transform.position;
        float distanciaHeroe = (miPos - posHeroe).magnitude;
        if (distanciaHeroe < rangoAgro && heroeJugador.GetComponent<Personaje>().estaVivo())
        {//heroe dentro del area agro
            //print("Jugador cerca");
            cerca = true;

            float nicolas = heroeJugador.transform.position.x;
            float glande = this.transform.position.x;
            if (nicolas < glande)
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);

            }
            else
            {
                transform.rotation = Quaternion.Euler(0, 180, 0);

            }
        }
        else
        {
            cerca = false;
        }
        if (cerca && heroeVivo && enemigoVivo)
        {
            miCuerpo.velocity = this.transform.right * -velocidadCaminar;
            miAnimador.SetBool("Caminando", true);
        }
        else
        {
            miCuerpo.velocity = Vector3.zero;
            miAnimador.SetBool("Caminando", false);
        }

        //ataque 
        if (distanciaHeroe < rangoAtk && heroeVivo && enemigoVivo)
        {
            miAnimador.SetTrigger("Atacar");
            miAnimador.SetBool("Camiando", false);
        }
    }





    private void OnCollisionEnter2D(Collision2D collision) //Metodo para hacer daño al enemigo
    {
        GameObject otroObjeto = collision.gameObject;
        if (otroObjeto.tag == "Player")
        {
            //print(name + "detecte colision con " + collision.gameObject);

            //Con esta instruccion se pbtiene el componente del Personaje Player
            Personaje elPerso = otroObjeto.GetComponent<Personaje>();
            //con esta instruccion se hace 20 de daño y digo quien realizo el daño
            elPerso.hacerDanio(puntosDanio, gameObject);
            GameObject efectoSpalsh = Instantiate(splashBloodPrefab);
            efectoSpalsh.transform.position = elPerso.transform.position;
            misSonidos.reporducir("daño");
            miAnimador.SetTrigger("DAÑO");
        }
    }
}
