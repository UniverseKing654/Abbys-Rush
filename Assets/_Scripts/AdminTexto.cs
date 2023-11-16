using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AdminTexto : MonoBehaviour
{
    public TextMeshProUGUI winText;


    void Update()
    {
        int winnerPlayer = FindObjectOfType<GameManager>().winnerNumber;
        winText.text = "Ha ganado el Jugador " + winnerPlayer.ToString();

    }
}
