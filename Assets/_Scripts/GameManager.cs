using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }


    public int winnerNumber;



    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;

            DontDestroyOnLoad(this.gameObject);
        }

        else
        {
            Debug.Log("Hay más de un GM activo.");
        }
    }




    public void CargarEscena(string escena)
    {
        SceneManager.LoadScene(escena);
    }




}