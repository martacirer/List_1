using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_7 : MonoBehaviour
{
  public GameObject sphere;

    private Material Transparent;

    private void Start() // Find the material.
    {
        Transparent = sphere.GetComponent<Renderer>().material;
    }

    // increase or release the opacity 
    public void ChangeOpacity(float value)
    {
        Transparent.color = new Vector4(Transparent.color.r, Transparent.color.g, Transparent.color.b, value);
    }
}
