using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EatingManager : MonoBehaviour {

    public GameObject obj;

    Transform[] foodBoxes;

    public void FoodEaten(Transform foodTransform)
    {
        foodBoxes = transform.GetComponentsInDirectChildren<Transform>();
        int count = 0;
        int childCount = foodBoxes.Length;

        for (int i = 0; i < childCount; i++)
        {
            Transform[] foodBoxesChildren = foodBoxes[i].GetComponentsInDirectChildren<Transform>();
            Transform foodInListTransform = foodBoxesChildren[0];
            if (foodInListTransform == foodTransform || foodInListTransform.gameObject.activeInHierarchy == false)
            {
                count++;
            }
        }
        if (count == childCount)
            EatingCompleted();
    }

    public UnityEvent OnEatingCompleted;

    private void EatingCompleted()
    {
        Debug.Log("Eating Phase completed");

        //if (OnEatingCompleted != null)
        //    OnEatingCompleted.Invoke();

        OnEatingCompleted.Invoke();
        
    }

   
}
