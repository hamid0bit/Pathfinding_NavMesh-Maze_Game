using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hint : MonoBehaviour
{
    public Button hintButton;
    public PLA PLA;
    public GameObject PopUp;

    public void HintButton()
    {
        if (PLA.Instance != null)
        {
            PLA.Instance.Pathfinding();
            //Debug.Log("Pathfinding executed");
        }
        else
        {
            Debug.LogWarning("PLA.Instance null.");
        }
    }
}

