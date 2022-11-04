using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_10_2 : MonoBehaviour
{
    private int number = 1;
    private Ex_10 ex_10;

    void Start()
    {
        ex_10 = FindObjectOfType<Ex_10>();
    }

    public void OnMouseDown()
    {
        //when click a sphere ,a point will be added to the counter
        ex_10.Points(number);
        Destroy(gameObject);
    }
}
