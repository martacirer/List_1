using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ex_2 : MonoBehaviour
{
    public TextMeshProUGUI textTMP;
    public int number;

    void Update()
    {
        // If you touch space it will tell you if it is even or odd
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            if (number %2 ==0)
            {
                // Show in the panel if is even
                textTMP.text = "" + number + " = EVEN";
            }
            else
            {
                // Show in the panel if is odd
                textTMP.text = "" + number + " = ODD";
            }
        }
    }
}
