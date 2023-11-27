using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraSeguidora : MonoBehaviour
{
    //Este es un atributo de la clase
    //que funciona como referencia a
    //la pelota de la escena
    public Transform cavernicola;
    void Start()
    {

    }

    void Update()
    {
        //Corta las lineas largas para que sean mas cortas pero ver punto y coma
        //le coloco la posicion de la pelota
        //a la camara, excepto en z
        transform.position =
            new Vector3(
                cavernicola.position.x,
                cavernicola.position.y + 2,
                -1);
    }
}
