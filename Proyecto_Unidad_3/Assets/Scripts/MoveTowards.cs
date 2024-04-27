using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowards : MonoBehaviour
{
    GameObject personaje;

    // Start is called before the first frame update
    void Start()
    {
        personaje = GameObject.Find("FirstPersonController");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(
            transform.position,
            personaje.transform.position,
            Time.deltaTime * 2f);
    }
}