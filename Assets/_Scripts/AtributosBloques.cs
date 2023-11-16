using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtributosBloques : MonoBehaviour
{

    public int HP;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Pickaxe")
        {
            HP -= collision.gameObject.GetComponent<AtributosPickaxe>().atkPower;
            if (HP < 1)
            {
                Destroy(gameObject);
            }

        }

        else if (collision.collider.tag == "Casco")
        {
            HP -= collision.gameObject.GetComponent<AtributosCasco>().atkPower;
            if (HP < 1)
            {
                Destroy(gameObject);
            }

        }


    }

}
