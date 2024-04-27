using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{

    [SerializeField]
    GameObject spawn_point;
    [SerializeField] float altura;
    int contadorMuertes;
    

    // Start is called before the first frame update
    void Start()
    {
        contadorMuertes = 0;
    }

    // Update is called once per frame
    void Update()
    {
        float y = transform.position.y;
        if (y < altura)
        {
            transform.position = spawn_point.transform.position;
            contadorMuertes++;
        }
    }

    public int ContadorMuertes() { 
    
        return contadorMuertes;
    }
}