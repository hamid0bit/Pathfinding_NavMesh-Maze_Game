using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MazeHard : MonoBehaviour
{
    public void back()
    {
        SceneManager.LoadScene("Select Level");
    }

    public void HardMaze1()
    {
        SceneManager.LoadScene("Hard - Maze1");
    }

    public void HardMaze2()
    {
        SceneManager.LoadScene("Hard - Maze2");
    }

    public void HardMaze3()
    {
        SceneManager.LoadScene("Hard - Maze3");
    }
}
