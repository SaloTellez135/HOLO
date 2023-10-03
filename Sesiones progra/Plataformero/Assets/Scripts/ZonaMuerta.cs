using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonaMuerta : MonoBehaviour
{
    public GameObject splashAguaPrefab;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject obj = collision.gameObject;
        if (obj.tag == "Player")
        {

            Personaje mono = obj.GetComponent<Personaje>();
            mono.instaMuerte(this.gameObject);
        }

        GameObject efectoSpash = Instantiate(splashAguaPrefab);

        efectoSpash.transform.position = mono.transform.position;
    }


}
