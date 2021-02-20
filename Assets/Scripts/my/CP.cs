using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CP : MonoBehaviour
{
    //[Tooltip("0 max back, 2 max front")]
    //[Range(0, 2)]
    [SerializeField] layerPos layer = layerPos.back;
    PlayerMov pm=null;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if(!pm)
                pm = FindObjectOfType<PlayerMov>();
            pm.checkPointPos = new Vector3(transform.position.x,transform.position.y,pm.lastZ-((int)layer*1.5f));
        }
    }
}

[Serializable]
public enum layerPos { back, middle, front }
