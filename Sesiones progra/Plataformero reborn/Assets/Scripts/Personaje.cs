using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Personaje : MonoBehaviour
{
    public enum TiposdeDanio
    {
        Fisico,
        Magico,
        Toxico
    }

    public int hp = 60;
    public int hpMax = 100;
    public int score = 0;
    public static int vidas = 3;
    private Animator miAnimador;
    public GameObject efectoSangrePrefab;
    private ReproductorSonidos misSonidos;
    public bool aturdido = false;
    public bool muerto = false;
    public GameObject efectoBurbujasPrefab;
    void Start()
    {
        misSonidos = GetComponent<ReproductorSonidos>();
        miAnimador = GetComponent<Animator>();
    }
    public void hacerDanio(int puntos, GameObject atacante, TiposdeDanio tipo = TiposdeDanio.Fisico)
    {
        print(name + "recibe daño de " + puntos + "por " + atacante.name + " de tipo" + tipo);
        hp = hp - puntos;
        misSonidos.reproducir("DAÑAR");
        Invoke("desaturdir", 1);
        if (hp <= 0 && vidas <= 0)
        {
            Personaje elPerso = GetComponent<Personaje>();
            elPerso.matar(this.gameObject);
        }    
        if (hp <= 0 && vidas > 0)
        {
            vidas--;
            muerto = true;
        }
        if(tipo == TiposdeDanio.Fisico)
        {
            miAnimador.SetTrigger("DAÑAR");
            aturdido = true;
            GameObject sangre = Instantiate(efectoSangrePrefab, transform);
        }
        else if (tipo == TiposdeDanio.Toxico)
        {
            GameObject burbujas = Instantiate(efectoBurbujasPrefab, transform);
        }

    }

    public void matar(GameObject atacante)
    {
        print(name + "Muere por " + atacante.name);
        vidas = 0;
        hp = 0;
        miAnimador.SetTrigger("MATAR");
        misSonidos.reproducir("MATAR");

        muerto = true;
    }
    private void desaturdir()
    {
        aturdido= false;
    }
}
