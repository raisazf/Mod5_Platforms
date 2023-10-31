using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge : MonoBehaviour
{
    // Start is called before the first frame update

    private bool triggered = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (triggered && transform.rotation.eulerAngles.x >= 180f)
            transform.Rotate(Vector3.right * (40f * Time.deltaTime));

        //Debug.Log(message:$"Bridge angle {transform.rotation.eulerAngles.x}");

    }


    public void OnTriggerEnter(Collider other)
    {

        Debug.Log("Bridge");
        triggered = true;
        Vector3 vecRot = new Vector3(90f, 0f, 0f);
        transform.Rotate(1f, 0f, 0f);

    }

}
