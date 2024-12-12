using System;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{

    private string input;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        

    
    }
    // Update is called once per frame
    void Update()
    {
           
    }

    public void ReadStringInput(string text)
    {
        input = text;
        Debug.Log("ReadStringInput: " + input);
    }
}
