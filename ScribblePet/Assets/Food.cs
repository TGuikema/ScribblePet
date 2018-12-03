using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Food : MonoBehaviour {

    public GameObject ARSpriteObject;

    public GameObject Popup;

    public UnityEvent OnCollectingCompleted;

    public void GetCollected()
    {
        //Debug.Log("GetCollected reached");

        //        ARSpriteObject = GameObject.Find("SweetSprite_4");
        //       ARSpriteObject.SetActive(false);

        //OnCollectingCompleted.AddListener(EventActions);
        //

        transform.parent.gameObject.SetActive(false);
        gameObject.SetActive(false);

        if (Popup != null)
            CollectionCompleted();      
    }

    private void CollectionCompleted()
    {

        Popup.SetActive(true);

        if (OnCollectingCompleted != null)
            OnCollectingCompleted.Invoke();
    }
}
