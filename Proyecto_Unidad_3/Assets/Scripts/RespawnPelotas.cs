using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPelotas : MonoBehaviour
{
    [SerializeField] List<GameObject> spawnList;
    int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float altura = transform.position.y;
        if (altura < 50)
        {
            index = Random.Range(0, spawnList.Count-1);
            transform.position = spawnList[index].transform.position;
            index = 0;
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        index = Random.Range(0, spawnList.Count - 1);
        transform.position = spawnList[index].transform.position;
        index = 0;
    }
}
