using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PocionCurar : MonoBehaviour
{
    private ReproductorSonidos misSonidos;
    private Animator miAnimador;
    public int curarPuntos = 20;
    public Personaje heroe;
    void Start()
    {
        miAnimador = GetComponent<Animator>();
        misSonidos = GetComponent<ReproductorSonidos>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D curar)
    {
        PocionCurar pocion = GetComponent<PocionCurar>();
        print(name + "hizo colision con" + curar.gameObject.name);
        GameObject otroObjeto = curar.gameObject;
        if (otroObjeto.CompareTag("Player"))
        {
            heroe = otroObjeto.GetComponent<Personaje>();
            if (heroe.hp < 81)
            {
                miAnimador.SetTrigger("OBTENER");
                heroe.hp = heroe.hp + curarPuntos;
                GetComponent<Collider2D>().enabled = false;
                Destroy(gameObject, 3);
                misSonidos.reproducir("BEBER");
            }              

        }
    }
}
