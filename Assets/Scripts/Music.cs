 using UnityEngine;
 
 public class Music : MonoBehaviour
 {
     private AudioSource audioSource;
     private void Awake()
     {
         DontDestroyOnLoad(transform.gameObject);
         audioSource = GetComponent<AudioSource>();
     }
 
     public void PlayMusic()
     {
         if (audioSource.isPlaying) return;
         audioSource.Play();
     }
 
     public void StopMusic()
     {
         audioSource.Stop();
     }
 }
