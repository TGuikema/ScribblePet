using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TGuikema;

public class Toggle : MonoBehaviour {

    public MyButton Button;
	// Use this for initialization
	void Start () {
        Button.OnButtonClick.AddListener(Toggle_Foldout);   //Subscribe the function to the inspector.
        Toggle_Foldout();
    }

    private void OnEnable()
    {

    }
    private void OnDisable()
    {
        
    }


    public void Toggle_Foldout()
    {
        if (gameObject.activeInHierarchy)
            gameObject.SetActive(false);
        else
            gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
