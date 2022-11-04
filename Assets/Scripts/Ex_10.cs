using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Ex_10 : MonoBehaviour
{
  public TextMeshProUGUI points;
  private int Counter;

    // the text appears in the screen
    public void Points(int number)
    {
        Counter += number;
        points.text = $"{Counter}";
        
    }
}
