using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorUI : MonoBehaviour
{

    public Personaje Heroe;
    public Text EtiquetaHPHeroe;
    public Image BarraHPHeroe;

    public Personaje Villano;
    public Text EtiquetaHPVillano;
    public Image BarraHPVillano;

    public Text scoreHeroe;
    public Text vidasHeroe;
    public Text vidasMaxHeroe;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //heroe

        EtiquetaHPHeroe.text = Heroe.hp + "/" + Heroe.hpMax;

        float porcentajeHPHeroe = Heroe.hp / (float)Heroe.hpMax;

        BarraHPHeroe.fillAmount = porcentajeHPHeroe;

        //villano

        EtiquetaHPVillano.text = Villano.hp + "/" + Villano.hpMax;

        float porcentajeHPVillano = Villano.hp / (float)Villano.hpMax;

        BarraHPVillano.fillAmount = porcentajeHPVillano;

        //score 

        scoreHeroe.text = "Score = " + Heroe.score;

        //num de vidas

        vidasHeroe.text = "Vidas = " + Heroe.vidasMax + "/" + Heroe.vidas;



    }
}
