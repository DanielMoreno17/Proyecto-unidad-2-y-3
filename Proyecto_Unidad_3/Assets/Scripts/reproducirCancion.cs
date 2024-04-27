using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reproducirCancion : MonoBehaviour
{
    public AudioSource cancion;
    public AudioClip Coral;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Cancion") 
        {
           cancion.Play();
        }
              
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Cancion")
        {
            cancion.Stop();
        }
    }
}
