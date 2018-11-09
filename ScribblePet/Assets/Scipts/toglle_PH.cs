using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TGuikema;

public class toglle_PH : MonoBehaviour {

    public MyButton Button;
	// Use this for initialization
	void Start () {
        Button.OnButtonClick.AddListener(Toggle);
        Toggle();
    }

    private void OnEnable()
    {
        
    }
    private void OnDisable()
    {
        //Button.OnButtonClick.RemoveListener(Toggle);
    }


    public void Toggle()
    {
        if (gameObject.activeInHierarchy)
            gameObject.SetActive(false);
        else
            gameObject.SetActive(true);
    }

	// Update is called once per frame
	void Update () {
		
	}
}
