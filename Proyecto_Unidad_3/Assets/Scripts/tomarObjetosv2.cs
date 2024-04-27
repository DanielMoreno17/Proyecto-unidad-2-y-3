using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;

public class tomarObjetosv2 : MonoBehaviour
{
    bool objCerca = false;
    GameObject objeto;
    bool objetoTomado = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(objCerca) {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if(objetoTomado)
                {
                    Debug.Log("Tomaste el objeto");
                    objeto.transform.SetParent(transform);
                    Rigidbody rb = objeto.GetComponent<Rigidbody>();
                    rb.isKinematic = true;
                    rb.useGravity = false;
                    objeto.transform.position = transform.position;
                }
                else
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
       
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject obj = other.gameObject;
        Debug.Log("Entraste en colision con: " + obj.name);
        if (obj.CompareTag("colores"))
        {
            objCerca = true;
            objeto = obj;

           
        }
    }

    private void OnTriggerExit(Collider other)
    {
        GameObject obj = other.gameObject;
        Debug.Log("Saliste en colision con: " + obj.name);
        if (obj.CompareTag("colores"))
        {
            objCerca = false;
            objeto = null;

        }
    }

}
