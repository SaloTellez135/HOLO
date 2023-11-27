using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesoroMoneda : MonoBehaviour
{
    private ReproductorSonidos misSonidos;
    private Animator miAnimador;
    public float monedas = 0;
    private Personaje heroe;
    public int aumentoScore = 4;
    // Start is called before the first frame update
    void Start()
    {
        miAnimador = GetComponent<Animator>();
        misSonidos = GetComponent<ReproductorSonidos>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D agarrar)
    {
        TesoroMoneda moneda = GetComponent<TesoroMoneda>();
        print(name + "hizo colision con" + agarrar.gameObject.name);
        GameObject otroObjeto = agarrar.gameObject;
        if (otroObjeto.CompareTag("Player"))
        {
            heroe = otroObjeto.GetComponent<Personaje>();
            miAnimador.SetTrigger("OBTENER");
            heroe.score = heroe.score + aumentoScore;
            monedas ++;
            GetComponent<Collider2D>().enabled = false;
            Destroy(gameObject, 3);
            misSonidos.reproducir("OBTENER");
        }
    }
}
