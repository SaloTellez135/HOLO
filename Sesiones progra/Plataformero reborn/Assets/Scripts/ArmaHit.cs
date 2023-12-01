using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaHit : MonoBehaviour
{
    public int puntosAtaque = 30;
    public GameObject splashBloodPrefab;

    void Start()
    {

    }
    void update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject otro = collision.gameObject;
        print("Arma " + name + " colisiona con " + collision);

        if (otro.tag == "Enemy")
        {

            Personaje enemigo = otro.GetComponent<Personaje>();
            enemigo.hacerDanio(puntosAtaque, this.gameObject);
            enemigo.quitarVidas();
            GameObject efectoSpalsh = Instantiate(splashBloodPrefab);
            efectoSpalsh.transform.position = enemigo.transform.position;



        }
    }
}