using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MazeMedium : MonoBehaviour
{
    public void back()
    {
        SceneManager.LoadScene("Select Level");
    }

    public void MediumMaze1()
    {
        SceneManager.LoadScene("Medium - Maze1");
    }

    public void MediumMaze2()
    {
        SceneManager.LoadScene("Medium - Maze2");
    }

    public void MediumMaze3()
    {
        SceneManager.LoadScene("Medium - Maze3");
    }
}
