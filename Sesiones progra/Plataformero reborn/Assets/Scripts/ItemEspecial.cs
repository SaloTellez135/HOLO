using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemEspecial : MonoBehaviour
{
    public bool obtenido = false;
    private ReproductorSonidos misSonidos;

    void Start()
    {
        misSonidos = GetComponent<ReproductorSonidos>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject otroObjeto = collision.gameObject;
        if (otroObjeto.tag == "Player")
        {
            obtenido = true;
            gameObject.GetComponent<Renderer>().enabled = false;
            misSonidos.reproducir("Boost");

        }
    }
    void Update()
    {

    }
}