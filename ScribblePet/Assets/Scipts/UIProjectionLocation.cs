using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class UIProjectionLocation : MonoBehaviour {

    public Transform trf;
    public Camera cam;

    private void Start()
    {
        /*if (cam == null)
        {
            
        }
        */
        //SetCameraComponent();
        //MethodTempName();
    }
    // Update is called once per frame
    void Update ()
    {
        

	}

    private void MethodTempName()
    {
        Debug.Log("Followed Path to UIPRojectionLocation, method MethodTempName");
        //trf.position = cam.WorldToScreenPoint(this.transform.position);
    }

    private void SetCameraComponent()
    {
        //cam = gameObject.GetComponent<Camera>();
    }
}
