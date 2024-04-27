using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class InciarNivel2 : MonoBehaviour
{
    GameManager gameManager;
    [SerializeField] GameObject spawner;
    [SerializeField] TextMeshProUGUI textoIniciar, textoContador, textoEstado;
    [SerializeField] GameObject inicioJuego, zonaSegura;
    public float tiempoTotal = 10f;
    private float tiempoRestante;
    private bool haColisionado = false, empezar = false, contando = false;
    // Start is called before the first frame update
    void Start()
    {

        gameManager = FindObjectOfType<GameManager>();
        textoContador.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (contando)
        {
            tiempoRestante -= Time.deltaTime;

            if (tiempoRestante <= 0.0f)
            {
                contando = false;

                StartCoroutine(ganar());
                               
            }
        }

        ActualizarTextoContador();
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("zonaSegura"))
        {
            textoIniciar.SetText("Presiona e para iniciar el juego");
            if (Input.GetKeyDown(KeyCode.E))
            {
                textoIniciar.SetText("");
                transform.position = inicioJuego.transform.position;
                GameObject[] spawns = GameObject.FindGameObjectsWithTag("spawnsInicio"); 
                foreach (GameObject spawn in spawns)
                {
                    Destroy(spawn);
                    
                    Debug.Log(spawn.name); 
                }

                GameObject[] spawnsJuego = GameObject.FindGameObjectsWithTag("spawnsJuego");
                foreach (GameObject spawn in spawnsJuego)
                {
                    spawn.SetActive(true);
                    GameObject spawnNuevo = Instantiate(spawner, spawn.transform.position, Quaternion.identity);
                }
                tiempoRestante = tiempoTotal;
                contando = true;
                textoContador.enabled = true;
                
            }
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("enemigo"))
        {
            haColisionado = true;
            StartCoroutine(perder());
           
        }
    }

    void ActualizarTextoContador()
    {
        int minutos = Mathf.FloorToInt(tiempoRestante / 60f);
        int segundos = Mathf.FloorToInt(tiempoRestante % 60f);

        textoContador.text = minutos.ToString("00") + ":" + segundos.ToString("00");
    }

    IEnumerator perder()
    {
        
        textoEstado.SetText("Has perdido, te han tocado los fantasmas :(");
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    IEnumerator ganar()
    {
        textoEstado.SetText("Has sobrevivido! :)");
        //transform.position = zonaSegura.transform.position;
        GameObject[] spawnsJuego = GameObject.FindGameObjectsWithTag("spawnsInicio");
        foreach (GameObject spawn in spawnsJuego)
        {
            Destroy(spawn);
        }
        GameObject[] enemigos = GameObject.FindGameObjectsWithTag("enemigo");
        foreach (GameObject en in enemigos)
        {
            Destroy(en);
        }
        textoContador.enabled = false;

        yield return new WaitForSeconds(2);
        gameManager.cambiarEscena("CargandoInicio");
    }

}
