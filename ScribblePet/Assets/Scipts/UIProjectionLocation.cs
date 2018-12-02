using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class UIProjectionLocation : MonoBehaviour {

   // public Transform trf;
    public Camera cam;

    public ExampleActivation exmActivate;
    public Transform rotateAroundTarget;

    void Start()
    {
        /*if (cam == null)
        {
            
        }
        */
        SetCameraComponent();
    }
    // Update is called once per frame
    void Update ()
    {

        MethodTempName();

    }

    private void MethodTempName()
    {

        
        Vector3 pos = cam.WorldToScreenPoint(rotateAroundTarget.position);
        pos.z = 0;

        RectTransform rectTransform = transform.GetComponent<RectTransform>();
        rectTransform.position = pos;
        //de nieuwe x = pos.x
        //de nieuwe y = pos.y
        // z bestaat niet, dus = 0


    }

    private void SetCameraComponent()
    {
        //Debug.Log("SetCameraComponent Reached.");
        //cam = gameObject.GetComponent<Camera>();

        cam = GameObject.Find("ARCamera").GetComponent<Camera>();
        


    }
}
