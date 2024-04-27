using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
public class menuBotoones : MonoBehaviour
{
    GameManager gameManager;
    [SerializeField] GameObject menu;
    private bool juegoPausado = false;
    
    void Start()
    {   
        gameManager = FindObjectOfType<GameManager>();
        
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
         if (juegoPausado)
            {
                continuar();
            }else
            {
                pausa();
            }
        }
    }
    
    private void pausa()
    {
        juegoPausado = true;
        Time.timeScale = 0f;
        menu.SetActive(true);
        Cursor.visible = true;
        Debug.Log("Se presiono boton pausa");
    }

    public void continuar()
    {
        juegoPausado = false;
        Time.timeScale = 1f;
        menu.SetActive(false);
        Cursor.visible = false;
        Debug.Log("Se presiono continuar");

    }

    public void restart()
    {
        juegoPausado = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Cursor.visible=false;
        Debug.Log("Se presiono reiniciar");

    }

    public void exit()
    {
        Time.timeScale = 1f;
        gameManager.cambiarEscena("CargandoIncio");

    }

}
