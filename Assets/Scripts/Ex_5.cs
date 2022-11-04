using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_5 : MonoBehaviour
{
 public GameObject Capsule;
    public Vector3[] position;

    void Update()
    {
        CapsuleArray(); 
    }

    void CapsuleArray()
    {
        // If press S key appears on the worldspace
        if (Input.GetKeyDown(KeyCode.S))
        {

            GameObject[] capsulesInGame = GameObject.FindGameObjectsWithTag("Capsule");


            foreach (Vector3 pos in position)
            {
                Instantiate(Capsule, pos, Capsule.transform.rotation);
            }
        }
    }
}
