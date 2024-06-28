using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu1 : MonoBehaviour
{
    private static Mainmenu1 instance = null;
    private AudioSource audioSource;
     void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            audioSource = GetComponent<AudioSource>();
            PlayMainSound();
        }else
        {
            Destroy(gameObject);

        }

    }
    public void PlayMainSound()
    { if (audioSource != null && !audioSource.isPlaying)

        {
            audioSource.Play();

        }
        void StopMainMenuSound()
        {
            if (audioSource != null && !audioSource.isPlaying)
            {
                audioSource.Stop();

            }

        }
          void LoadScene1()
        {
            SceneManager.LoadScene ("scene1");


        }
                void QuitGame()
        {
            Debug.Log("Quit Game ");
            Application.Quit();
        }



    }


     
        
        
        
    }






