using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1_LookAt : MonoBehaviour
{
    [SerializeField] GameObject personaje;

    void Start()
    {
        personaje = GameObject.Find("FirstPersonController");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = personaje.transform.position;
        transform.LookAt(pos);
        pos.y = transform.position.y;
        
    }
}
