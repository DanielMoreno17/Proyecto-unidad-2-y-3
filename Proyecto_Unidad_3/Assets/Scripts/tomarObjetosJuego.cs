using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;

public class tomarObjetosJuego : MonoBehaviour
{
    bool objCerca = false;
    GameObject objeto;
 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(objCerca) {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Tomaste el objeto");
                objeto.transform.SetParent(transform);
                Rigidbody rb = objeto.GetComponent<Rigidbody>();
                rb.isKinematic = true;
                rb.useGravity = false;
                objeto.transform.position = transform.position;
                objeto.transform.rotation = transform.rotation;

            }
            if (Input.GetKeyUp(KeyCode.E))
            {
                Debug.Log("Liberaste el objeto");
                objeto.transform.SetParent(null);
                Rigidbody rb = objeto.GetComponent<Rigidbody>();
                rb.isKinematic = false;
                rb.useGravity = true;
                //objeto.transform.position = transform.position;
                //objeto.transform.rotation = transform.rotation;

            }
        }
       
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject obj = other.gameObject;
        Debug.Log("Entraste en colision con: " + obj.name);
        if (obj.CompareTag("tomable"))
        {
            objCerca = true;
            objeto = obj;

           
        }
    }

    private void OnTriggerExit(Collider other)
    {
        GameObject obj = other.gameObject;
        Debug.Log("Saliste en colision con: " + obj.name);
        if (obj.CompareTag("tomable"))
        {
            objCerca = false;
            objeto = null;

        }
    }

}
