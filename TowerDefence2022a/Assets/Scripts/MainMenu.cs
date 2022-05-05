using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void QuitGame()
    {

#if UNITY_EDITOR                //Simulation for the editor since there is no application to close in play mode.
        UnityEditor.EditorApplication.isPlaying = false;
#endif

        Application.Quit();
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void LoadMap1()
    {
        SceneManager.LoadScene("Map 1");
    }


    public void LoadMap2()
    {
        SceneManager.LoadScene("Map 2");
    }

}
