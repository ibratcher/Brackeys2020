using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    
    [SerializeField]
    private GameObject levelCompleteText = null;

    private float resetDelay = 2;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void Win()
    {
        levelCompleteText.SetActive(true);
        Time.timeScale = .5f;
        Invoke("Reset", resetDelay);
    }

    public void Reset()
    {
        Time.timeScale = 1f;
        if(SceneManager.GetActiveScene().name == "LevelOne")
        {
            SceneManager.LoadScene("LevelTwo");
        }
        switch (SceneManager.GetActiveScene().name)
        {
            case "LevelOne":
            SceneManager.LoadScene("LevelTwo");
            break;

            case "LevelTwo":
            SceneManager.LoadScene("LevelThree");
            break;

            default:
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            break;
            
        }
            
    }
}
