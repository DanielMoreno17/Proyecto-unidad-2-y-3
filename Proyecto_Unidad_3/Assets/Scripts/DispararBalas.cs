using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DispararBalas : MonoBehaviour
{

    public GameObject BalaInicio;
    public GameObject BalaPrefab;
    public float BalaVelocidad;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {

            GameObject BalaTemporal = Instantiate(BalaPrefab, BalaInicio.transform.position, BalaInicio.transform.rotation) as GameObject;


            Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();


            rb.AddForce(transform.forward * BalaVelocidad);


            Destroy(BalaTemporal, 5.0f);
        }
    }

}
