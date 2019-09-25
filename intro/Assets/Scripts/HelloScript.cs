using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelloScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ChangeText = "Hello World!";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ChangeText(string text)
    {
        GetComponent<Text>().text = text;
    }
}
