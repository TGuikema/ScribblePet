using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyVeryFirstScript : MonoBehaviour {

    public void Showcase()
    {
        int[] intArray = new int[2] { 0, 2 };
        int test = intArray[5];
        Debug.LogError("THIS FUCKING MOUSE");
    }

    public void Interact()
    {
        Debug.LogWarning("Interacting");
    }

    public void Hello(string name)
    {
        Debug.Log("Hello " + name);
    }
}                     
