using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MazeEasy : MonoBehaviour
{
    public void back()
    {
        SceneManager.LoadScene("Select Level");
    }

    public void EasyMaze1()
    {
        SceneManager.LoadScene("Easy - Maze1");
    }

    public void EasyMaze2()
    {
        SceneManager.LoadScene("Easy - Maze2");
    }

    public void EasyMaze3()
    {
        SceneManager.LoadScene("Easy - Maze3");
    }
}
