using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    // Update is called once per frame

    private Vector3 orig_Position;

    public void Start()
    {
        orig_Position = transform.position;
    }
    void FixedUpdate()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        transform.gameObject.SetActive(false);
    }

}
