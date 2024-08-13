using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectLevel : MonoBehaviour
{
    public void EasyButton()
    {
        SceneManager.LoadScene("Level - Easy");
    }

    public void MediumButton()
    {
        SceneManager.LoadScene("Level - Medium");
    }

    public void HardButton()
    {
        SceneManager.LoadScene("Level - Hard");
    }

    public void Back()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
