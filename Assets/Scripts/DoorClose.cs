using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorClose : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        GameObject[] close = GameObject.FindGameObjectsWithTag("Door");

        foreach (GameObject go in close)
        {
            go.SetActive(true);
        }

    }
}
