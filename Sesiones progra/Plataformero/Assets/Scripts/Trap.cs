using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {//Este metodo se dispara cuando este objeto detecta una colision... cum



        GameObject otroObjeto = collision.gameObject; 
        if (otroObjeto.tag == "Player")
        {
            print(name + "detecte colision con " + collision.gameObject);

            //Con esta instruccion se pbtiene el componente del Personaje Player
            Personaje elPerso = otroObjeto.GetComponent<Personaje>();
            //con esta instruccion se hace 20 de daño y digo quien realizo el daño
            elPerso.hacerDanio(20, gameObject);

        }

        


    }
}
