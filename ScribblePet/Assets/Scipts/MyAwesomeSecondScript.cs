using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAwesomeSecondScript : MonoBehaviour {

    public MyVeryFirstScript mvfs;

	// Use this for initialization
	void Start () {
        mvfs.Hello("Thom");
        mvfs.Interact();
        mvfs.Showcase();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
