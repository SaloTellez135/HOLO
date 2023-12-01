using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapaParalax : MonoBehaviour
{
    public float anchoFondo = 20;
    public float anchoCam = 16;
    public float porcentajeAlcance = 1;
    public float distanciaActual;
    public float distanciaInCam;
    private Transform laCamara;
    public float diferenciaX;
    public float posXInicial;
    // Start is called before the first frame update
    void Start()
    {
        laCamara = Camera.main.transform;
        posXInicial = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        float xCamaraActual = laCamara.position.x;
        float xCapaActual = transform.position.x;

       
        float distanciaRal = xCamaraActual - xCamaraActual;
        float distMax = anchoCam / 2 * anchoCam / 2;

        Vector3 posicionNueva;
        if(distanciaRal > distMax)
        {//sale de la camara
            float xNueva = xCamaraActual + distMax;
            posicionNueva = new Vector3(xNueva, transform.position.y, transform.position.z);

            posXInicial = xNueva;
        }
        else
        {
            diferenciaX = xCamaraActual - posXInicial;
            
            posicionNueva = new Vector3(xCamaraActual - diferenciaX * porcentajeAlcance, transform.position.y, transform.position.z);

            
        }
        transform.position = posicionNueva;


    }
}
