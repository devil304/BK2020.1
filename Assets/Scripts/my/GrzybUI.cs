using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GrzybUI : MonoBehaviour
{
    [SerializeField] int max = 0, act = 0;
    TextMeshProUGUI counter;
    [SerializeField] Quest MyQ;
    // Start is called before the first frame update
    void Start()
    {
        counter = GetComponent<TextMeshProUGUI>();
        counter.text = act + "/" + max;
    }

    public void cup()
    {
        act+=act<max?1:0;
        if (act == max)
        {
            MyQ.Done();
        }
        counter.text = act + "/" + max;
    }
}
