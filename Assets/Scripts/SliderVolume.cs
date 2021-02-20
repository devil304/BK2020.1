using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderVolume : MonoBehaviour
{
    AudioSource[] AudioSources;
    Slider myS;
    public void Awake()
    {
        myS = GetComponent<Slider>();
        AudioSources = FindObjectsOfType<AudioSource>();
        if (PlayerPrefs.HasKey("Volume")) {
            myS.value = PlayerPrefs.GetFloat("Volume");
            for (int i = 0; i < AudioSources.Length; i++)
                AudioSources[i].volume = myS.value;
        }
    }
    public void Volume(float SliderV)
    {
        //myS.value = SliderV;
        for (int i = 0; i < AudioSources.Length; i++)
            AudioSources[i].volume = SliderV;        
    }

    private void OnDisable()
    {
        PlayerPrefs.SetFloat("Volume",myS.value);
    }
}
