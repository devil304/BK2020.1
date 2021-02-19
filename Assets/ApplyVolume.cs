using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyVolume : MonoBehaviour
{
    private void Awake()
    {
        GetComponent<AudioSource>().volume=SliderVolume.VolumeChange;

    }

}
