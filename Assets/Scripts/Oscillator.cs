using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Oscillator : MonoBehaviour
{

    [Header("Movement Parameters")]

    public Vector3 movementAxis;
    public float movementSpeed;
    public float movementDistance;

    [Header("Movement Positions")]

    public Vector3 startingPosition;
    public Vector3 positivEnd;
    public Vector3 negativeEnd;

    private Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        direction = movementAxis.normalized;


        startingPosition = transform.position;
        positivEnd = transform.position + (direction * movementDistance);
        negativeEnd = transform.position - (direction * movementDistance);

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Vector3.Distance(transform.position, positivEnd) < 0.01f || Vector3.Distance(transform.position, negativeEnd) < 0.01f)
        { direction *= -1; }
        //Debug.Log(message: $"{transform.position} {direction * movementDistance} {positivEnd}  {negativeEnd}");

        transform.Translate(direction * movementSpeed * Time.deltaTime);
    }

    public void OnTriggerEnter(Collider other)
    {
        other.gameObject.transform.position = transform.position;
    }
}
