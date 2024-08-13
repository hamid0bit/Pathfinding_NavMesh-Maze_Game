using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movescene : MonoBehaviour
{
    public void menu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void selectlevel()
    {
        SceneManager.LoadScene("Select Level");
    }

    public void maze1()
    {
        SceneManager.LoadScene("Hard - Maze3");
    }
}
