using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularMovement : MonoBehaviour {

	[SerializeField]
	Transform rotationCenter;

    [SerializeField]
	float rotationRadius = 2f, angularSpeed = 2f;

	float posX, posY, angle = 0f;

    private void Start()
    {
        if (rotationCenter == null)
            rotationCenter = transform;
    }

    // Update is called once per frame
    void Update () {
		posX = rotationCenter.localPosition.x + Mathf.Cos (angle) * rotationRadius;
		posY = rotationCenter.localPosition.y + Mathf.Sin (angle) * rotationRadius;
		transform.localPosition = new Vector2 (posX, posY);
		angle = angle + Time.deltaTime * angularSpeed;

		if (angle >= 360f)
			angle = 0f;
	}
}
