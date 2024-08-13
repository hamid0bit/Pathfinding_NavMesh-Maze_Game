using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerSettings : MonoBehaviour
{
    public Text TextTimer;
    public float Time;

    bool GameActive = false;
    public GameObject GameOver;



    void SetText()
    {
        int Menit = Mathf.FloorToInt(Time / 60);
        int Detik = Mathf.FloorToInt(Time % 60);
        TextTimer.text = Menit.ToString("00") + ":" + Detik.ToString("00");
    }

    float s;
    private void Update()
    {
        if (!GameActive)
        {
            s += UnityEngine.Time.deltaTime;
            if (s >= 1)
            {
                Time--;
                s = 0;
            }

            if (Time <= 0)
            {
                Lose();
            }
        }


        SetText();
    }


    void Lose()
    {
        Debug.Log("Game Kalah");
        GameActive = true; // Setel gameLost menjadi true agar kondisi tidak dipenuhi lagi
        UnityEngine.Time.timeScale = 0;
        GameOver.SetActive(true);
    }

}

