using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CavnerNicolasCam : MonoBehaviour
{
    //esto es un atributo publico
    public Transform Caver_Nicolas;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
            Caver_Nicolas.position.x, //pos x
            Caver_Nicolas.position.y, //pos y
            -1); //pos z


    }
}

