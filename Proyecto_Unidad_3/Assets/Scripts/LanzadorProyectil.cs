using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class LanzadorProyectil : MonoBehaviour
{
    [SerializeField]
    GameObject bala;

    [SerializeField]
    GameObject spawnBala;
    

    public List<GameObject> balas;
    float tiempoespera = 3f;

    // Start is called before the first frame update
    void Start()
    {
        balas = new List<GameObject>();
        for (int i = 0; i < 10; i++)
        {
            GameObject b = Instantiate(bala,
                spawnBala.transform.position,
                spawnBala.transform.rotation
            );
            b.SetActive(false);
            balas.Add(b);
        }
        contBalaDisparada = 0;
    }

    int contBalaDisparada;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {

            Debug.Log("Disparo");
            //GameObject b = Instantiate(bala, 
            //    spawnBala.transform.position,
            //    spawnBala.transform.rotation
            //);
            //Destroy(b, 4);

            balas[contBalaDisparada].SetActive(true);
            // StartCoroutine(Desaparecer());
            contBalaDisparada++;

            if (contBalaDisparada >= 10)
            {
                contBalaDisparada = 0;
                for (int i = 0; i < balas.Count; i++)
                {
                  //  balas[i].transform.position = Vector3(spawnBala.transform.position, spawnBala.transform.rotation);

                }

            }
            /*

            IEnumerator Desaparecer()
            {

                balas[contBalaDisparada].SetActive(false);
                Debug.Log("Se inicio la corrutina");
                yield return new WaitForSeconds(tiempoespera);

            }
            */
        }
    }

}