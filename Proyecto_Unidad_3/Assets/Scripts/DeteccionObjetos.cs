using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class DeteccionObjetos : MonoBehaviour
{
    int contador = 0;    // Start is called before the first frame update
     [SerializeField] TextMeshProUGUI cont;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject obj = other.gameObject;
        Debug.Log("Entraste en colision con: " + obj.name);
        if (obj.CompareTag("tomable"))
        {
            contador++;
            cont.SetText("Objetos introducidos: " + contador);
            obj.SetActive(false);


        }

    }
}
