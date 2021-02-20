using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;
using UnityEngine.SceneManagement;

public class MainMenuScriptJ : MonoBehaviour
{
    [SerializeField] PlayerMov pm;
    [SerializeField] Animator CamA;
    [SerializeField] SliderVolume SV;
    [SerializeField] Volume gamma;
    [HideInInspector] public LiftGammaGain LGG = null;
    public AudioSource[] MMaGM;
    [SerializeField] float time = 1.75f;
    public Canvas c;

    private void Awake()
    {
        SV.Awake();
        gamma.profile.TryGet(out LGG);
        if (LGG != null && PlayerPrefs.HasKey("Gamma"))
            LGG.gamma.value = new Vector4(LGG.gamma.value.x, LGG.gamma.value.y, LGG.gamma.value.z, PlayerPrefs.GetFloat("Gamma"));

    }
    public void PlayGame ()
    {
        pm.enabled = true;
        CamA.SetBool("Start",true);
        c.enabled = false;
        MMaGM[1].volume = 0;
        actVol = MMaGM[0].volume;
        MMaGM[1].Play();
        StartCoroutine(changeM());
        Time.timeScale = 1f;
        if(pm.mainI!=null)
            pm.mainI.Enable();
    }
    [HideInInspector] public float timea = 0, actVol;
    IEnumerator changeM()
    {
        while(MMaGM[1].volume < actVol * 0.9f) {
            MMaGM[1].volume = Mathf.Lerp(0, actVol, timea / time);
            MMaGM[0].volume = Mathf.Lerp(actVol, 0, timea / time);
            timea += Time.deltaTime;
            yield return null;
        }
        MMaGM[0].volume = 0;
        MMaGM[0].Stop();
        MMaGM[1].volume = actVol;
    }
    public IEnumerator changeMB()
    {
        while (MMaGM[0].volume < actVol * 0.9f)
        {
            MMaGM[0].volume = Mathf.Lerp(0, actVol, timea / time);
            MMaGM[1].volume = Mathf.Lerp(actVol, 0, timea / time);
            timea += Time.deltaTime;
            yield return null;
        }
        MMaGM[1].volume = 0;
        MMaGM[1].Stop();
        MMaGM[0].volume = actVol;
    }
    public void QuitGame ()
    {
        //Debug.Log("QUIT!");
        Application.Quit();
    }


}
