using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1_Fuerzas : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    [SerializeField] float fuerza;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //rb.AddTorque(Vector3.right);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        rb.AddForce(transform.right * fuerza , ForceMode.Acceleration); // ignora la masa y se utiliza cuando el personaje se mueve
    //  rb.AddForce(transform.right * fuerza , ForceMode.Force);
        rb.AddForce(transform.right * fuerza, ForceMode.VelocityChange);
    }
}
