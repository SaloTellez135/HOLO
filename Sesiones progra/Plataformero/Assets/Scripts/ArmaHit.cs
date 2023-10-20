using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaHit : MonoBehaviour
{

   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D contrincante)
    {


        GameObject otroObjeto = contrincante.gameObject;
        if (otroObjeto.tag == "Mob")
        {
            print(name + " le dio un madrazo a " + contrincante.gameObject);
            Personaje malvado = otroObjeto.GetComponent<Personaje>();
            malvado.hacerDanio(35, this.gameObject);

        }
    }
}
