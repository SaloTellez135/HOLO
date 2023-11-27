using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CofreTesoro : MonoBehaviour
{
    private ReproductorSonidos misSonidos;
    private Animator miAnimador;
    public GameObject tesoro;
    public bool cercaCofre = false;
    public GameObject boton;
    public GameObject efectoBrilloPrefab;
    void Start()
    {
        miAnimador = GetComponent<Animator>();
        misSonidos = GetComponent<ReproductorSonidos>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire2") && cercaCofre)
        {
            miAnimador.SetTrigger("OBTENER");
            Instantiate(tesoro, transform.position, Quaternion.identity);
            misSonidos.reproducir("ABRIR");

        }

    }
    private void OnTriggerEnter2D(Collider2D abrir)
    {
        
        CofreTesoro cofre = GetComponent<CofreTesoro>();
        print(name + "hizo colision con" + abrir.gameObject.name);
        GameObject otro = abrir.gameObject;
        
        if (otro.tag == "Player")
        {
            cercaCofre = true;
            boton.SetActive(true);
            misSonidos.reproducir("ENTRAR");
            GameObject brillo = Instantiate(efectoBrilloPrefab, transform);
        }
    }
    private void OnTriggerExit2D(Collider2D fuera)
    {

        CofreTesoro cofre = GetComponent<CofreTesoro>();
        print(name + "salio de" + fuera.gameObject.name);
        GameObject otro = fuera.gameObject;

        if (otro.tag == "Player")
        {
            cercaCofre = false;
            boton.SetActive(false);
        }
    }
}
