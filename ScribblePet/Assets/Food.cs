using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour {

    public GameObject ARSpriteObject;

    public void GetCollected()
    {

        ARSpriteObject.SetActive(false);
        gameObject.SetActive(false);
    }
}
