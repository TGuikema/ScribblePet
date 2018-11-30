using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
    }

    // Update is called once per frame
    public float DebugSpeed = 10;

	void Update () {
        /*if (Input.GetKey(KeyCode.Space))
            transform.Translate(-DebugSpeed, 0, 0);

        if(Input.touchCount > 0)
        {
            transform.Translate(-DebugSpeed, 0, 0);
        }
        */
	}

    private bool isTriggered = false;

    /*public void OnCollisionEnter2D(Collision2D other)
    {
        //other.gameObject.GetCom
        Collision();
    }*/

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Food collidedFoodProjection = collision.gameObject.GetComponent<Food>();
   

        collidedFoodProjection.GetCollected();
        Collision();
    }

    private void Collision()
    {
        isTriggered = true;
        Debug.Log("Collision detected.");

    }
}
