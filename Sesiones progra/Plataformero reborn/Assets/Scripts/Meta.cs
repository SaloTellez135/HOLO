using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Meta : MonoBehaviour
{
    public GameObject cavernicola;
    public GameObject celebrationPrefab;
    private ReproductorSonidos misSonidos;
    public ItemEspecial objeto;
    private Animator miAnimador;

    void Start()
    {
        misSonidos = GetComponent<ReproductorSonidos>();
        miAnimador = GetComponent<Animator>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject otroObjeto = collision.gameObject;
        if (otroObjeto.tag == "Player")
        {
            Personaje elPerso = otroObjeto.GetComponent<Personaje>(); // con esto le mando daño al personaje por 20 puntos y le digo que fue este objeto el que lo daño
            elPerso.festejo();
            misSonidos.reproducir("CELEBRATION");

            GameObject celebracion = Instantiate(celebrationPrefab);
            celebracion.transform.position = this.transform.position;


            Invoke("siguienteEscena", 6f);
            if (objeto.obtenido == true)
            {
                Personaje.vidas = Personaje.vidas + 2;
                print("las vidas ahora son" + Personaje.vidas);
            }
        }
    }

    private void siguienteEscena()
    {
        SceneManager.LoadScene("Limbo");
    }
}