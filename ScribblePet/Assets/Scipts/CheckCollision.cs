using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    bool isTriggered = false;

    /*public void OnCollisionEnter2D(Collision2D other)
    {
        //other.gameObject.GetCom
        Collision();
    }*/

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Collision();
    }

    private void Collision()
    {
        isTriggered = true;
        Debug.Log("Collision detected.");

        OnGUI();
    }

    private void OnGUI()
    {
        if (isTriggered == true)
        {
            GUI.Label(new Rect(10, 10, 100, 20), "Collider Detected.");
            return;
        }
    }


    /* OTHER VERSION.(This does however not work completely right.)
     * 
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Collision();
    }

    private void Collision()
    {
        isTriggered = true;
        Debug.Log("Collision detected.");

        Communicator();
    }

    private void Communicator()
    {

        if (isTriggered == true)
        {
            OnGUI();
            return;
        }

    }

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 20), "Collider Detected.");
    }
     */
}
