using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minar : MonoBehaviour
{

    public float cooldownPickaxe = 0f;
    private float anteriorPickaxe;

    public GameObject pickaxePrefab;

    private Vector3 picktransformspawn = new Vector3(0f, 0f, 0f);



    public void Pickaxe(bool isFacingRight, float horizontal, float vertical, Transform tf, bool buff, bool debuff, int playerNumber)
    {
        if (Time.time - anteriorPickaxe < cooldownPickaxe)
        {
            return;
        }


        if (vertical < 0)
        {
            picktransformspawn = new Vector3(tf.position.x, tf.position.y - 1f, 0f);
            
        }

        if (isFacingRight && vertical >= 0)
        {
            picktransformspawn = new Vector3(tf.position.x + 1f, tf.position.y, 0f);
            
        }

        else if (!isFacingRight && vertical >= 0)
        {
            picktransformspawn = new Vector3(tf.position.x - 1f, tf.position.y, 0f);
            
        }

        GameObject PickaxeInst = Instantiate(pickaxePrefab, picktransformspawn, Quaternion.identity);
        PickaxeInst.GetComponent<AtributosPickaxe>().playerNumber = playerNumber;

        if (buff)
        {
            PickaxeInst.GetComponent<AtributosPickaxe>().atkPower = 2;
        }

        else if (debuff)
        {
            PickaxeInst.GetComponent<AtributosPickaxe>().atkPower = 0;
        }


        anteriorPickaxe = Time.time;









    }


}
