using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScriptJ : MonoBehaviour
{
    public void PlayGame ()
    {
        StartCoroutine(LoadYourAsyncScene());
    }
    public void QuitGame ()
    {
        //Debug.Log("QUIT!");
        Application.Quit();
    }

    IEnumerator LoadYourAsyncScene()
    {

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);

       
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }

}
