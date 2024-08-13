using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject pauseMenu;

    public void PauseControl()
    {
        if (Time.timeScale == 1)
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1; 
            pauseMenu.SetActive(false);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void Menu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void Next()
    {
        SceneManager.LoadScene(1);
    }

    public void NextEasy()
    {
        SceneManager.LoadScene("Level - Easy");
    }

    public void NextMedium()
    {
        SceneManager.LoadScene("Level - Medium");
    }

    public void NextHard()
    {
        SceneManager.LoadScene("Level - Hard");
    }


    public void Instruction()
    {
        SceneManager.LoadScene("Instruction");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
