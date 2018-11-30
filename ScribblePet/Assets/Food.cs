using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour {

    public GameObject ARSpriteObject;


    public void GetCollected()
    {
        Debug.Log("GetCollected reached");
        ARSpriteObject = GameObject.Find("SweetSprite_4");

        


        ARSpriteObject.SetActive(false);
        gameObject.SetActive(false);
    }
}
