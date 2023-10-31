using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetGameObjectActive : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject gameObjectActivate;
    public void OnTriggerEnter(Collider other)
    {

        gameObjectActivate.gameObject.SetActive(true);

    }
}
