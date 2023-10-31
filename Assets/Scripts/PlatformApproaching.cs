using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformApproaching : MonoBehaviour
{
    //[SerializeField] private GameObject gameObjectActivate;
    [SerializeField] private Oscillator oscillatorActivate;

    private Vector3 origPosition;
    private float orgMovementSpeed;

    public void Start()
    {
        origPosition = gameObject.transform.position;
        orgMovementSpeed = oscillatorActivate.movementSpeed;
    }
    public void OnTriggerEnter(Collider other)
    {


        Debug.Log(message:$"object name {other.gameObject.name}");
        if (other.gameObject.tag != "Platform") return;
        oscillatorActivate.movementSpeed = oscillatorActivate.movementSpeed / 3f;
        gameObject.transform.position = origPosition;
        gameObject.GetComponent<Rigidbody>().isKinematic = true;
        Debug.Log("Platform Near");
        gameObject.GetComponent<Renderer>().material.color = Color.green;

    }
    public void OnTriggerExit(Collider other)
    {

        Debug.Log("Platform further");
        //gameObjectActivate.gameObject.SetActive(true);
        gameObject.GetComponent<Renderer>().material.color = Color.red;
        oscillatorActivate.movementSpeed = orgMovementSpeed;

    }
}
