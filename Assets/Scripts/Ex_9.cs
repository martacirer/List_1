using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ex_9 : MonoBehaviour
{
  public GameObject pointL;
    public Toggle ToggleL;

 

    public void Toggle()
    {
        //if is on ,light is on
        if(ToggleL.isOn == true)
        {
            pointL.SetActive(true);
        }
        //if is off, light is off
        else
        {
            pointL.SetActive(false);
        }
    }
}
