using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaEnemigo : MonoBehaviour
{
    // Start is called before the first frame update
    public int puntosAtk = 20;
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

        if (otro.tag == "Player")
        {

            Personaje enemigo = otro.GetComponent<Personaje>();
            enemigo.hacerDanio(puntosAtk, this.gameObject);
            GameObject efectoSpalsh
               = Instantiate(splashBloodPrefab);
            efectoSpalsh.transform.position
                = enemigo.transform.position;
        }
    }
}
