using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minar : MonoBehaviour
{

    public float cooldownPickaxe = 0f;
    private float anteriorPickaxe;

    public GameObject pickaxePrefab;



    public void Pickaxe(bool isFacingRight, float horizontal, float vertical, Transform tf)
    {
        if (Time.time - anteriorPickaxe < cooldownPickaxe)
        {
            return;
        }


        if (vertical < 0)
        {
            Vector3 picktransformspawn = new Vector3(tf.position.x, tf.position.y - 1f, 0f);
            GameObject PickaxeInst = Instantiate(pickaxePrefab, picktransformspawn, Quaternion.identity);
            anteriorPickaxe = Time.time;
        }



        if (isFacingRight && vertical >= 0)
        {
            Vector3 picktransformspawn = new Vector3(tf.position.x + 1f, tf.position.y, 0f);
            GameObject PickaxeInst = Instantiate(pickaxePrefab, picktransformspawn, Quaternion.identity);
            anteriorPickaxe = Time.time;
        }

        else if (!isFacingRight && vertical >= 0)
        {
            Vector3 picktransformspawn = new Vector3(tf.position.x - 1f, tf.position.y, 0f);
            GameObject PickaxeInst = Instantiate(pickaxePrefab, picktransformspawn, Quaternion.identity);
            anteriorPickaxe = Time.time;
        }







    }


}
