using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BotonesTitulo : MonoBehaviour
{

    public Button play;
    public Button quit;
    public string destination;


    void Start()
    {

        Button pbtn = play.GetComponent<Button>();
        pbtn.onClick.AddListener(Jugar);


        Button qbtn = quit.GetComponent<Button>();
        qbtn.onClick.AddListener(Salir);

    }


    void Jugar()
    {

        FindObjectOfType<GameManager>().CargarEscena(destination);
    }


    void Salir()
    {
        Application.Quit();
    }

}