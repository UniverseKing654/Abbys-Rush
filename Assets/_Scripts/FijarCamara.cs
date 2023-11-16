using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FijarCamara : MonoBehaviour
{
    public Transform target;
    [SerializeField] float position;

    void LateUpdate()
    {
        transform.position = new Vector3(position, target.position.y, -10f);
        transform.rotation =  Quaternion.identity;
    }


}

