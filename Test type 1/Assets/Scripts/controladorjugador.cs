using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladorjugador : MonoBehaviour
{
    public float fuerzasalto = 5;
    //referecnia al componente ridgid body
    private Rigidbody2D miCuerpo;


    // Start is called before the first frame update
    void Start()
    {
        miCuerpo = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {//si en eset frame fue presionado el 
         // boton para el salto 
            print("se presiono salto");
            //aplico una fuerza por impulso en el eje Y
            miCuerpo.AddForce(
                new Vector3(0, fuerzasalto, 0), ForceMode2D.Impulse);

        }
    }
}
