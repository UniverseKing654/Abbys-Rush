using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatilloMeta : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Player")
        {
            GameObject jugadorGanador = collision.gameObject;
            //Debug.Log("Contacto");
            FindObjectOfType<GameManager>().winnerNumber = jugadorGanador.GetComponent<MovimientoJugador>().playerNumber;
            FindObjectOfType<GameManager>().CargarEscena("Victoria");
        }
    }
}
