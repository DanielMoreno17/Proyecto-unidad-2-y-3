using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Pendulum : MonoBehaviour
{
	float speed = 20f;
	float limit = 75f; //Limit in degrees of the movement
	bool randomStart = true; //If you want to modify the start position
	private float random = 0;
	Rigidbody rb;

    // Start is called before the first frame updatesd
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Awake()
    {
		if(randomStart)
			random = Random.Range(0f, 1f);
	}

    // Update is called once per frame
    void Update()
    {
		float angle = limit * Mathf.Sin(Time.time + random * speed);
		transform.localRotation = Quaternion.Euler(0, 0, angle);
	}

}
