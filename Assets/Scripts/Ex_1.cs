using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ex_1 : MonoBehaviour
{
    public TextMeshProUGUI textTMP;

    //Min num
    private int Min = 0;
    //Max num
    private int Max = 200;

    // Random number
    public void RandomNumber()
    {
        // Show the result in the panel
        textTMP.text = Random.Range(Min, Max).ToString();
    }
}
