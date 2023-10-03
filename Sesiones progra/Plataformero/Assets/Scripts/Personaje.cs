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


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void hacerDanio(int puntDanio,GameObject villano)
    {
        hp = hp - puntDanio;
        print(name + "recibe daño de " + puntDanio + "por " + villano);
    }

    public void instaMuerte(GameObject quien)
    {
        hp = 0;
        print(name + " murio ahogado");
    }
}
