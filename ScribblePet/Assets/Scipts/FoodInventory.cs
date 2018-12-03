using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodInventory : MonoBehaviour {


    public EatingManager EatingManager;
    
    private void Reset()
    {
        EatingManager = transform.parent.parent.GetComponent<EatingManager>();
    }

    void OnDisable()
    {
        //Debug.Log("PrintOnDisable: script was disabled");
        EatingManager.FoodEaten(transform);
    }

    void OnEnable()
    {
        //Debug.Log("PrintOnEnable: script was enabled");
    }
}
