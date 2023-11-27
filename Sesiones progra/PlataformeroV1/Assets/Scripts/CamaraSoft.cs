using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraSoft : MonoBehaviour
{
    public Personaje objetivo;
    public float offsetProfundidad = -5;
    public float offsetVertical = -1;
    public float velocidadAlcance = 2;
   
    // LateUpdate is called once per frame after all updates
    void LateUpdate()
    {
        Vector3 posDestino = new Vector3(objetivo.transform.position.x, objetivo.transform.position.y + offsetVertical, objetivo.transform.position.y + offsetProfundidad);
        transform.position = Vector3.Lerp(transform.position, posDestino, Time.deltaTime * velocidadAlcance);
    }
}
