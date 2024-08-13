using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public float scoreAmount;
    public float scoreDecreasePerSecond;
    void Start()
    {
        scoreAmount = 1000f;
        scoreDecreasePerSecond = 1f;
    }

    // Update is called once per frame
    void Update()
    {

        scoreText.text = (int)scoreAmount + "";
        scoreAmount -= scoreDecreasePerSecond * Time.deltaTime;
    }
}
