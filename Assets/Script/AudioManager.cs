using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public AudioSource gameplayMusicSource;
    public static AudioManager instance;
    public bool[] isMusicStop;
    public bool isStop;

    void Start()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            Debug.Log("Not Destroy");
        }
        else
        {
            Destroy(gameObject);
            Debug.Log("Destroy");
        }
    }

    void Update()
    {
        if (isStop == false)
        {
            PauseMusic();
        }
        else
        {
            ContinueMusic();
        }
    }

    void PauseMusic()
    {
        for (int i = 0; i < isMusicStop.Length; i++)
        {
            if (isMusicStop[i] == true && SceneManager.GetActiveScene().buildIndex == i)
            {
                gameplayMusicSource.Pause();
                isStop = true;
                Debug.Log("Background Music Paused");

                break;
            }
        }
    }

    void ContinueMusic()
    {
        for (int i = 0; i < isMusicStop.Length; i++)
        {
            if (isMusicStop[i] == false && SceneManager.GetActiveScene().buildIndex == i)
            {
                gameplayMusicSource.Play();
                isStop = false;
                Debug.Log("Background Music Continue");

                break;
            }
        }
    }
}