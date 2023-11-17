using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtributosBloques : MonoBehaviour
{

    public int HP;

    public bool rubyPower = false;
    public bool sapphirePower = false;
    public bool emeraldPower = false;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Pickaxe")
        {
            HP -= collision.gameObject.GetComponent<AtributosPickaxe>().atkPower;
            if (HP < 1)
            {
                Destroy(gameObject);

                if (rubyPower == true)
                {
                    GameObject player = GameObject.Find("Player" + collision.gameObject.GetComponent<AtributosPickaxe>().playerNumber);
                    player.GetComponent<AtributosPowerups>().rubyPower = true;
                }
                else if (sapphirePower == true)
                {
                    GameObject player = GameObject.Find("Player" + collision.gameObject.GetComponent<AtributosPickaxe>().playerNumber);
                    player.GetComponent<AtributosPowerups>().sapphirePower = true;
                }
                else if (emeraldPower == true)
                {
                    GameObject player = GameObject.Find("Player" + collision.gameObject.GetComponent<AtributosPickaxe>().playerNumber);
                    player.GetComponent<AtributosPowerups>().emeraldPower = true;
                }
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
