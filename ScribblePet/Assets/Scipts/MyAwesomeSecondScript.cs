using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TGuikema; // Another way to call on the namespace.

public class MyAwesomeSecondScript : MonoBehaviour {

    public MyVeryFirstScript mvfs;

	// Use this for initialization
	void Start () {
        mvfs.Hello("Thom");
        mvfs.Interact();
        mvfs.Showcase();
	}
	
    public void Nope()
    {

    }

	// Update is called once per frame
	void Update () {
		
	}
}
