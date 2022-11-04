using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_6 : MonoBehaviour
{
    public GameObject Cylinder;

    private Material CoulorCap;

    private void Start()
    {
        // Search material
       CoulorCap = Cylinder.GetComponent<Renderer>().material;
    }

    // Put the color at the cylinder
    public void ChangeColor(int index)
    {
        switch (index)
        {
            case 0:
                CoulorCap.color = Color.red;
                break;

            case 1:
                CoulorCap.color = Color.blue;
                break;

            case 2:
                CoulorCap.color = Color.green;
                break;

            case 3:
                CoulorCap.color = Color.yellow;
                break;

            case 4:
                CoulorCap.color = Color.black;
                break;

            default:
                CoulorCap.color = Color.white;
                break;
        }
    }
}
