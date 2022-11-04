using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX_3 : MonoBehaviour
{
   // Posicions for random value.
    private float xPosition;
    private float yPosition;
    private float zPosition;

    // Ranges
    private float xRange = 200f;
    private float yRange = 200f;
    private float zRange = 200f;

    void Update()
    {
        // if you touch enter key...
        if (Input.GetKeyDown(KeyCode.Return))
        {
            // Appears cube in random position
            xPosition = Random.Range(-xRange, xRange);
            yPosition = Random.Range(-yRange, yRange);
            zPosition = Random.Range(-zRange, zRange);

            // Move cube in random position
            transform.position = new Vector3(xPosition, yPosition, zPosition);
        }
    }
}
