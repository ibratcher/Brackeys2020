using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Start()
    {
        GameObject.FindGameObjectWithTag("Music").GetComponent<Music>().PlayMenuMusic();
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("LevelOne");
        GameObject.FindGameObjectWithTag("Music").GetComponent<Music>().PlayMainMusic();
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void OpenCredits()
    {
        SceneManager.LoadScene("Credits");
        GameObject.FindGameObjectWithTag("Music").GetComponent<Music>().PlayMenuMusic();
    }

    public void ExitCredits()
    {
        SceneManager.LoadScene("Menu");
    }
}
