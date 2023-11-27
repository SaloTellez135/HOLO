using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PocionVelocidad : MonoBehaviour
{
    private ReproductorSonidos misSonidos;
    private Animator miAnimador;
    private ControladorJugador persoPlayer;
    public int velocidadMas = 2;
    public GameObject efectoRayosPrefab;

    void Start()
    {
        misSonidos = GetComponent<ReproductorSonidos>();
        miAnimador = GetComponent<Animator>();

    }


    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D aumentar)
    {
        GameObject otro = aumentar.gameObject;
        if (otro.CompareTag("Player"))
        {
            persoPlayer = otro.GetComponent<ControladorJugador>();
            PocionVelocidad pocion = GetComponent<PocionVelocidad>();
            print(name + "hizo colision con" + aumentar.gameObject.name);
            GameObject otroObjeto = aumentar.gameObject;
            if (otroObjeto.CompareTag("Player"))
            {
                miAnimador.SetTrigger("OBTENER");
                GetComponent<Collider2D>().enabled = false;
                Destroy(gameObject, 3);
                persoPlayer.velocidadCaminar = persoPlayer.velocidadCaminar * velocidadMas;
                Invoke("velocidadAumentada", 2f);
                GetComponent<Collider2D>().enabled = false;
                misSonidos.reproducir("BEBER");
                GameObject rayos = Instantiate(efectoRayosPrefab, transform);
            }
        }
    }


    public void velocidadAumentada()
    {
        Debug.Log("Velocidad orginal");
        if (persoPlayer != null)
        {
            misSonidos.reproducir("RAYOS");
            persoPlayer.velocidadCaminar = persoPlayer.velocidadCaminar / velocidadMas;
            Debug.Log("Velocidad caminar = " + persoPlayer.velocidadCaminar);
        }
    }


}
