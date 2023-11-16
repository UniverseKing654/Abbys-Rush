using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtributosPowerups : MonoBehaviour
{

    public bool rubyPower = false;
    public bool sapphirePower = false;
    public bool emeraldPower = false;


    private IEnumerator coroutine;

    public void UsarGema(int playerNumber)
    {

        Debug.Log("Skill activada");

        if (rubyPower == true) {
            RubyFlames();
        }

        if (sapphirePower == true)
        {
            SapphireGrowth();
        }

        if (emeraldPower == true)
        {
            EmeraldPoison();
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


    void SapphireGrowth()
    {
        //Inserte expansi�n
        
        sapphirePower= false;

    }



    void EmeraldPoison()
    {
        
        Debug.Log("EmeraldPoison");
        coroutine = EmeraldWearOff(5f);
        StartCoroutine(coroutine);
    }

    IEnumerator RubyWearOff(float time)
    {   
        GetComponent<MovimientoJugador>().debuff = true;
        yield return new WaitForSeconds(time);
        GetComponent<MovimientoJugador>().debuff = false;
        emeraldPower = false;
    }



}
