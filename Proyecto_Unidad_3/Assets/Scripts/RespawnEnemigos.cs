using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class RespawnEnemigos: MonoBehaviour
{
    [SerializeField] private GameObject enemigoPrefab;
    [SerializeField] private float spawnRadius = 5f;
    [SerializeField] private float spawnDelat = 1.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", spawnDelat, spawnDelat);
    }


    public void Spawn() 
    {
        Vector2 puntoAleatorio = Random.insideUnitCircle * spawnRadius;
        Vector3 offset = new Vector3(puntoAleatorio.x, 0f, puntoAleatorio.y);
        Instantiate(enemigoPrefab, transform.position + offset, Quaternion.identity);
       
    }

    private void OnDrawGizmos()
    {   
        Gizmos.color = Color.green;
        Gizmos.DrawSphere(transform.position, 0.5f);
        Gizmos.DrawWireSphere(transform.position, 5f);
    }

}
