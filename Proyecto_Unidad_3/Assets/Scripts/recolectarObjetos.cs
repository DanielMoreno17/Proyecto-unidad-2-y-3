using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class recolectarObjetos : MonoBehaviour
{
     GameManager gameManager;
    [SerializeField] TextMeshProUGUI gold;
    [SerializeField] TextMeshProUGUI shield;
    [SerializeField] TextMeshProUGUI health;
    [SerializeField] TextMeshProUGUI estado;

    int goldCont = 0, shieldCont = 0, healthCont = 0;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if ( goldCont >= 6 &&  shieldCont >= 3 && healthCont >  = 3)
        {
            StartCoroutine(ganar());
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("gold"))
        {
            goldCont++;
            gold.SetText("Gold: " + goldCont.ToString() + " / 6");
            Debug.Log("Agarraste oro");

        }
        else if (other.gameObject.CompareTag("shield"))
        {
            shieldCont++;
            shield.SetText("Shield: " + shieldCont.ToString() + " / 3");
            Debug.Log("Agarraste escuado");
        }
        else if (other.gameObject.CompareTag("health"))
        {
            healthCont++;
            health.SetText("health: " + healthCont.ToString() + " / 3");
            Debug.Log("Agarraste vida");
        }
    }

    IEnumerator ganar()
    {
        gold.enabled = false;
        shield.enabled = false;
        health.enabled = false;
        estado.SetText("Has encontrado todos los objetos perdidos!");
        yield return new WaitForSeconds(3);
        gameManager.cambiarEscena("CargandoInicio");

    }

    
}
