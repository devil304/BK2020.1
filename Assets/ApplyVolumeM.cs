using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyVolumeM : MonoBehaviour
{
    AudioSource myAS;
    private void Awake()
    {
        myAS = GetComponent<AudioSource>();

    }

    private void Update()
    {
        myAS.volume = SliderVolume.VolumeChange;
    }
}
