using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateWorldToCanvasSpace : MonoBehaviour {

    public RectTransform MainCanvas;
    public Camera MainCamera;
    public Vector3 Position;
	// Use this for initialization
	void Start ()
    {
        WorldToCanvasPosition(MainCanvas, MainCamera, Position);
	}
	
	// Update is called once per frame
	void Update () {}

    /// <summary>
    /// Description
    /// </summary>
    /// <param name="canvas">Current Canvas</param>
    /// <param name="camera">Camera to use</param>
    /// <param name="position">Object position</param>
    /// <returns></returns>
    private Vector2 WorldToCanvasPosition(RectTransform canvas, Camera camera, Vector3 position)
    {
        
        //Vector position (percentage from 0 to 1) considering camera size.
        //For example (0,0) is lower left, middle is (0.5,0.5)
        Vector2 temp = camera.WorldToViewportPoint(position);

        //Calculate position considering our percentage, using our canvas size
        //So if canvas size is (1100,500), and percentage is (0.5,0.5), current value will be (550,250)
        temp.x *= canvas.sizeDelta.x;
        temp.y *= canvas.sizeDelta.y;

        //The result is ready, but, this result is correct if canvas recttransform pivot is 0,0 - left lower corner.
        //But in reality its middle (0.5,0.5) by default, so we remove the amount considering canvas rectransform pivot.
        //We could multiply with constant 0.5, but we will actually read the value, so if custom rect transform is passed(with custom pivot) , 
        //returned value will still be correct.

        temp.x -= canvas.sizeDelta.x * canvas.pivot.x;
        temp.y -= canvas.sizeDelta.y * canvas.pivot.y;

        return temp;
        



    }

    private Vector2 WorldToCanvasPosition(RectTransform canvas, Vector3 position)
    {
        return WorldToCanvasPosition(canvas, Camera.main, position);
    }

}
