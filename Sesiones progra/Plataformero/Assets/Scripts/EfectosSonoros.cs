using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[RequireComponent(typeof(AudioSource))]
public class EfectosSonoros : MonoBehaviour
{
    public Efecto[] misEfectos;
    private AudioSource Reporductor;

    void Start()
    {
       Reporductor  = GetComponent<AudioSource>();
    }


    public void reporducir(string accion)
    {
        foreach(Efecto efe in misEfectos)
        {
            //si la accion del efecto corresponde con la accion solicitada en el parametro
            if (efe.accion == accion)
            {
                //asigno el sonido al reproductor
                Reporductor.clip = efe.sonido;
                Reporductor.Play();
                //corta la ejecucion del ciclo
                return;
            }
        }
    }

    [Serializable]
    public class Efecto
    {
        public string accion;
        public AudioClip sonido;
    }

}
