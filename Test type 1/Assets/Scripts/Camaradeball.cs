using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camaradeball: MonoBehaviour
{
    //esto es un atributo publico
    public Transform Pelota;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
            Pelota.position.x, //pos x
            Pelota.position.y, //pos y
            -1); //pos z

          
    }
}
