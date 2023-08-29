using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlJugador : MonoBehaviour
{
    private Rigidbody2D MiCuerpo;
    private Animator Mianimador;
    // Start is called before the first frame update
    void Start()
    {
        MiCuerpo = GetComponent<Rigidbody2D>();
        Mianimador = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float velVert = MiCuerpo.velocity.y;
        MiCuerpo.velocity = new Vector3(5, velVert, 0);

        Mianimador.SetBool("Caminando", true);

    }
}
