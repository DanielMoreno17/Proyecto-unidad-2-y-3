using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;

public class verificacionNivel4 : MonoBehaviour
{
    GameManager gameManager;
    [SerializeField] TextMeshProUGUI textoEstado;
    [SerializeField] TextMeshProUGUI textoEstrellas;
    int estrellasCont;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        estrellasCont = 0;
        textoEstrellas.SetText("Estrellas recolectadas: " + estrellasCont + " / 4");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("star"))
        {
            estrellasCont++;
            textoEstrellas.SetText("Estrellas recolectadas: " + estrellasCont + " / 4");

        }
        
        
        if (other.gameObject.name == "finalizar" && estrellasCont >= 4)
        {
            StartCoroutine(ganar());
        }

        if (other.gameObject.name == "finalizar" && estrellasCont != 4)
        {
            StartCoroutine(faltanEstrellas());
            
        }


    }

    IEnumerator faltanEstrellas()
    {
        textoEstado.SetText("Faltan estrellas por encontrar!");
        yield return new WaitForSeconds(2);
        textoEstado.SetText("");
    }

    IEnumerator ganar()
    {
        textoEstado.SetText("Has resuelto el laberinto!");
        textoEstrellas.SetText("");
        yield return new WaitForSeconds(3);
        gameManager.cambiarEscena("CargandoInicio");
    }
}

