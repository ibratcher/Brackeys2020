using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    public GameObject levelCompleteText = null;

    public float resetDelay;

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
        //Reset the scene
    }

    public void Reset()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
