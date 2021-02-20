using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderGamma : MonoBehaviour
{
    [SerializeField] MainMenuScriptJ MMS;
    Slider myS;
    public void Awake()
    {
        myS = GetComponent<Slider>();
        if (PlayerPrefs.HasKey("Gamma")) {
            myS.value = PlayerPrefs.GetFloat("Gamma");
        }
    }
    public void Volume(float SliderV)
    {
        if(MMS.LGG!=null)
            MMS.LGG.gamma.value = new Vector4(MMS.LGG.gamma.value.x, MMS.LGG.gamma.value.y, MMS.LGG.gamma.value.z, SliderV);
    }

    private void OnDisable()
    {
        PlayerPrefs.SetFloat("Gamma",myS.value);
    }
}
