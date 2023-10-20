using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    public int hp = 70;
    public int hpMax = 100;
    public int vidas = 3;
    public int score = 0;
    public int vidasMax = 3;
    public GameObject splashBlood;
    public GameObject corazao;
    private Animator animador;
    private EfectosSonoros misSonidos;

    // Start is called before the first frame update
    void Start()
    {
        animador = GetComponent<Animator>();
        misSonidos = GetComponent<EfectosSonoros>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void hacerDanio(int puntDanio, GameObject villano)
    {
        if (hp > 0)
        {
            hp = hp - puntDanio;
            print(name + "recibe da�o de " + puntDanio + " pt por " + villano);
            Personaje elPerso = this.GetComponent<Personaje>();
            GameObject efectoSlpash = Instantiate(splashBlood);
            efectoSlpash.transform.position = this.transform.position;
            animador.SetTrigger("Daniar");
            misSonidos.reporducir("Danio");
        }

        if (hp < 1)
        {
            //Con esta instruccion se pbtiene el componente del Personaje Player
            Personaje elPerso = this.GetComponent<Personaje>();
            GameObject splashCorazao = Instantiate(corazao);
            splashCorazao.transform.position = this.transform.position;
            animador.SetTrigger("Morir");
            misSonidos.reporducir("grito");

        }
    }


    public void instaMuerte(GameObject quien)
    {
        hp = 0;
        print(name + " murio ahogado");
        animador.SetTrigger("Morir");
        misSonidos.reporducir("grito");
        //misSonidos.reporducir("Splash");
    }

    
}
