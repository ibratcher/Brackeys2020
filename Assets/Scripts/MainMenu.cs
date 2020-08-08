using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Awake()
    {
        try
        {
            GameObject.FindGameObjectWithTag("Music").GetComponent<Music>().StopMusic();
        }
        catch
        {
            //Placeholder
        }

    }
    public void PlayGame()
    {
        SceneManager.LoadScene("LevelOne");
        GameObject.FindGameObjectWithTag("Music").GetComponent<Music>().PlayMusic();
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
