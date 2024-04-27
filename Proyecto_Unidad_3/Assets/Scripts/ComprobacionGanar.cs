using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ComprobacionGanar : MonoBehaviour
{
    private GameManager gameManager;
    [SerializeField] TextMeshProUGUI textoGanar;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Finish")
        {
            textoGanar.SetText("¡Has ganado el juego!");
            StartCoroutine(Esperar(4));
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Finish")
        {
            textoGanar.SetText("");
        }
    }

    IEnumerator Esperar(float tiempo)
    {
        yield return new WaitForSeconds(tiempo);
        gameManager.cambiarEscena("CargandoInicio");
    }

}
