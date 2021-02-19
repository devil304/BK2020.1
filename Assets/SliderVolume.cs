using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderVolume : MonoBehaviour
{
    
    public static float VolumeChange=1;
    public void Volume(float SliderV)
    {
        VolumeChange = SliderV;
    }
}
