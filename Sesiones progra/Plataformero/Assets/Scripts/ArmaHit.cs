using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaHit : MonoBehaviour
{

    public int puntosAtk = 15;
    private void OnCollisionEnter2D(Collision2D contrincante)
    {


        GameObject otroObjeto = contrincante.gameObject;
        if (otroObjeto.tag == "Mob")
        {
            print(name + " le dio un madrazo a " + contrincante.gameObject);
            Personaje malvado = otroObjeto.GetComponent<Personaje>();
            malvado.hacerDanio(puntosAtk, this.gameObject);

        }
    }
}
