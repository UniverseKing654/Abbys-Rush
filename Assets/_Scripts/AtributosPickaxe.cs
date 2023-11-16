using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtributosPickaxe : MonoBehaviour
{
    private float lifeSpan = 0.2f;
    public int atkPower = 1;

    public int playerNumber;
    [SerializeField] bool permanente = false;

    private void Start()
    {
        if (permanente == false)

        {
            StartCoroutine(esperar(lifeSpan));
        }
 
    }

    private IEnumerator esperar(float sec)
    {
        yield return new WaitForSeconds(sec);
        Destroy(gameObject);
      
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ( permanente == false)
        {
            Destroy(gameObject);
        }
    }


}
