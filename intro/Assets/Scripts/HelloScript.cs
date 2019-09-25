using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelloScript : MonoBehaviour
{
    int Counter = 0;

    string originalText = "Counting Down: ";
    string continuedText = "";

    float floatDemo = 10.0f / 3.0f;
    double doubleDemo = 10.0 / 3.0;

    // Start is called before the first frame update
    void Start()
    {
        continuedText = "Floate value: " + floatDemo + "\n" + "Double value: " + doubleDemo;

        ChangeText(originalText + "\n" + continuedText);
    }

    // Update is called once per frame
    void Update()
    {
        Counter++;
        ChangeText(originalText + Counter + "\n" + continuedText);
    }

    private void ChangeText(string text)
    {
        GetComponent<Text>().text = text;
    }
}
