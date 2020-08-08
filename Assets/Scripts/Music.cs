 using UnityEngine;
 using UnityEngine.SceneManagement;
 
 public class Music : MonoBehaviour
 {
    private AudioSource music;
    
    [SerializeField]
    private AudioClip menuMusic;

    [SerializeField]
    private AudioClip mainGameMusic;

    
    private void Awake()
    {
        if (GameObject.FindGameObjectsWithTag("Music").Length <= 1)
        {
            DontDestroyOnLoad(transform.gameObject);
        }
        music = GetComponent<AudioSource>();
    }

 
    public void PlayMainMusic()
    {
        if(music.clip == mainGameMusic)
        {
            return;
        }
        else
        {
            music.clip = mainGameMusic;
            music.Play();
        }
    }

    public void PlayMenuMusic()
    {
        if(music.clip == menuMusic)
        {
            return;
        }
        else
        {
            music.clip = menuMusic;
            music.Play();
        }
        
    }
 
    public void StopMusic()
    {
        music.Stop();
    }
 }
