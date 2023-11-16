using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtributosPowerups : MonoBehaviour
{

    public bool rubyPower = false;
    public bool sapphirePower = false;
    public bool emeraldPower = false;

    public GameObject pickaxePrefab;


    private IEnumerator coroutine;

    public void UsarGema(int playerNumber, Transform tf)
    {

        Debug.Log("Skill activada");

        if (rubyPower == true) {
            RubyFlames();
        }

        if (sapphirePower == true)
        {
            SapphireGrowth(tf);
        }

        if (emeraldPower == true)
        {
            EmeraldPoison(playerNumber);
        }

    }



    void RubyFlames()
    {
        
        //Inserte poder bola de fuego
        Debug.Log("RubyFlames");
        coroutine = RubyWearOff(5f);
        StartCoroutine(coroutine);
        
    }

    IEnumerator RubyWearOff(float time)
    {   
        GetComponent<MovimientoJugador>().buff = true;
        yield return new WaitForSeconds(time);
        GetComponent<MovimientoJugador>().buff = false;
        rubyPower = false;
    }


    void SapphireGrowth(Transform tf)
    {
        //Inserte expansi�n

        Debug.Log("SapphireGrowth");

        Vector3 picktransformspawn1 = new Vector3(tf.position.x, tf.position.y - 1f, 0f);
        Vector3 picktransformspawn2 = new Vector3(tf.position.x, tf.position.y - 3f, 0f);
        Vector3 picktransformspawn3 = new Vector3(tf.position.x, tf.position.y - 5f, 0f);
        Vector3 picktransformspawn4 = new Vector3(tf.position.x, tf.position.y - 7f, 0f);
        Vector3 picktransformspawn5 = new Vector3(tf.position.x, tf.position.y - 9f, 0f);


        GameObject PickaxeInst1 = Instantiate(pickaxePrefab, picktransformspawn1, Quaternion.identity);
        PickaxeInst1.GetComponent<AtributosPickaxe>().atkPower = 3;
        GameObject PickaxeInst2 = Instantiate(pickaxePrefab, picktransformspawn2, Quaternion.identity);
        PickaxeInst2.GetComponent<AtributosPickaxe>().atkPower = 3;
        GameObject PickaxeInst3 = Instantiate(pickaxePrefab, picktransformspawn3, Quaternion.identity);
        PickaxeInst3.GetComponent<AtributosPickaxe>().atkPower = 3;
        GameObject PickaxeInst4 = Instantiate(pickaxePrefab, picktransformspawn4, Quaternion.identity);
        PickaxeInst4.GetComponent<AtributosPickaxe>().atkPower = 3;
        GameObject PickaxeInst5 = Instantiate(pickaxePrefab, picktransformspawn5, Quaternion.identity);
        PickaxeInst5.GetComponent<AtributosPickaxe>().atkPower = 3;

        
        sapphirePower= false;

    }



    void EmeraldPoison(int playerNumber)
    {
        
        Debug.Log("EmeraldPoison");
        coroutine = EmeraldWearOff(5f, playerNumber);
        StartCoroutine(coroutine);
    }

    IEnumerator EmeraldWearOff(float time, int playerNumber)
    {   

        GameObject player = GameObject.Find("Player" + ((playerNumber%2)+1));

        Debug.Log(playerNumber);
        Debug.Log("Player" + ((playerNumber%2)+1));

        player.GetComponent<MovimientoJugador>().debuff = true;
        yield return new WaitForSeconds(time);
        player.GetComponent<MovimientoJugador>().debuff = false;
        emeraldPower = false;
    }



}
