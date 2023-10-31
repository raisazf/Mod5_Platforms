using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HelloWorld : MonoBehaviour
{
    public TextMeshProUGUI textObject;
    public float maxScale;

    private float scaleFactor = 0.001f;
    private TextMeshProUGUI myText;

    // Start is called before the first frame update
    void Start()
    {
        myText = textObject.GetComponent<TextMeshProUGUI>();
        myText.fontSize = 0.001f;

        Debug.Log("Hello Wold!");
    }

    // Update is called once per frame
    void Update()
    {
        if (myText.fontSize < maxScale) 
        {
            myText.fontSize = myText.fontSize + scaleFactor;
        }
        
    }
}
