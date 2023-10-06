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

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void hacerDanio(int puntDanio, GameObject villano)
    {
        hp = hp - puntDanio;
        print(name + "recibe daño de " + puntDanio + "por " + villano);
        if (hp <= 0)
        {

            //Con esta instruccion se pbtiene el componente del Personaje Player
            Personaje elPerso = this.GetComponent<Personaje>();
            GameObject efectoSlpash = Instantiate(corazao);
            efectoSlpash.transform.position = this.transform.position;

        }
    }


    public void instaMuerte(GameObject quien)
    {
        hp = 0;
        print(name + " murio ahogado");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {//Este metodo se dispara cuando este objeto detecta una colision... cum



        GameObject otroObjeto = collision.gameObject;
        if (otroObjeto.tag == "Danio")
        {
            print(name + " se dio en la madre con " + collision.gameObject);

            //Con esta instruccion se pbtiene el componente del Personaje Player
            Personaje elPerso = this.GetComponent<Personaje>();
            GameObject efectoSlpash = Instantiate(splashBlood);
            efectoSlpash.transform.position = this.transform.position;

        }
        
    }

    
}
