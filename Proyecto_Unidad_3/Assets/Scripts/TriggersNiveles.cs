using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggersNiveles : MonoBehaviour
{
    private GameManager gameManager;
    [SerializeField] TextMeshProUGUI texto;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        texto.SetText("Presiona e para continuar");
    }

    private void OnTriggerStay(Collider other)
    {

        if (other.CompareTag("Trigger1"))
        {
            if (Input.GetKey(KeyCode.E))
            {
                gameManager.cambiarEscena("Cargando1");
            }
        }
        else

        if (other.CompareTag("Trigger2"))
        {
            if (Input.GetKey(KeyCode.E))
            {
                gameManager.cambiarEscena("Cargando2");
            }
        }
        else 

        if (other.CompareTag("Trigger3"))
        {
            if (Input.GetKey(KeyCode.E))
            {
                gameManager.cambiarEscena("Cargando3");
            }
        }
        else

        if (other.CompareTag("Trigger4"))
        {
            if (Input.GetKey(KeyCode.E))
            {
                gameManager.cambiarEscena("Cargando4");
            }
        }
        else

        if (other.CompareTag("Trigger5"))
        {
            if (Input.GetKey(KeyCode.E))
            {
                gameManager.cambiarEscena("Cargando5");
            }
        }

                
    }

    private void OnTriggerExit(Collider other)
    {
        texto.SetText("");
    }
    
    IEnumerator esperar()
    {
        gameManager.cambiarEscena("Cargando1");
        yield return new WaitForSeconds(2f);
        
    }

   
     
}
