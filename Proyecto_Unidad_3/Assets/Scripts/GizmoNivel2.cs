using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmoNivel2     : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawCube(transform.position, new Vector3(1, 1, 1));
    }
    
}
