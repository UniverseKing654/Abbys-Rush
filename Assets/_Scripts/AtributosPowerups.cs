using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtributosPowerups : MonoBehaviour
{

    public bool rubyPower = false;
    public bool sapphirePower = false;
    public bool emeraldPower = false;




    public void UsarGema()
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
        
        rubyPower = false;
        
    }


    void SapphireGrowth()
    {
        //Inserte expansión
        
        sapphirePower= false;

    }



    void EmeraldPoison()
    {
        
        //Inserte slow

        emeraldPower= false;
        
      
    }



}
