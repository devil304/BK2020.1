using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class blockFinish : MonoBehaviour
{
    BoxCollider myBC;
    Quest[] quests;
    [SerializeField] TextMeshProUGUI tmpT;
    [SerializeField] string text;
    private void Start()
    {
        myBC = GetComponent<BoxCollider>();
        quests = FindObjectsOfType<Quest>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        bool tmp = true;
        foreach(Quest q in quests)
        {
            if (!q.done)
            {
                tmp = false;
                break;
            }
        }
        if (tmp)
            myBC.enabled = false;
        else
        {
            tmpT.text = text;
            tmpT.enabled = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        tmpT.enabled = false;
    }
}
