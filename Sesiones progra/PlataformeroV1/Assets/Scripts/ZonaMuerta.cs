using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonaMuerta : MonoBehaviour
{
    public GameObject splashAguaPrefab;
    public EfectosSonoros audioAwa;

    void Start()
    {
        audioAwa = GetComponent<EfectosSonoros>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject obj = collision.gameObject;
        if (obj.tag == "Player")
        {

            Personaje mono = obj.GetComponent<Personaje>();
            mono.instaMuerte(this.gameObject);

            GameObject efectoSlpash = Instantiate(splashAguaPrefab);
            efectoSlpash.transform.position = mono.transform.position;

            audioAwa.reporducir("Awa");

        }
    }
}
