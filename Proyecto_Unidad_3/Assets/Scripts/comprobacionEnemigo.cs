using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comprobacionEnemigo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("zonaSegura"))
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }
}
