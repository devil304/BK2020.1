using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grzybek : MonoBehaviour
{    
    PlayerMov player;
    GrzybUI Gui;
    [SerializeField] float MinDist=2;

    private void OnEnable()
    {
        Gui = FindObjectOfType<GrzybUI>();
        player = FindObjectOfType<PlayerMov>();
        player.usee += check;
    }
    public void check()
    {
        if (Vector3.Distance(player.transform.position, transform.position) <= MinDist)
        {
            Gui.cup();
            Destroy(gameObject);
        }
    }

    private void OnDisable()
    {
        player.usee -= check;
    }
}
