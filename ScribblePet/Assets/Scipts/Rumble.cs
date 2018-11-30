using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rumble : MonoBehaviour {

    public float speed = 1.0f; //how fast it shakes
    public float amount = 1.0f; //how much it shakes

    public bool XRumble, YRumble, ZRumble;
    



    private void Update()
    {
        RumbleAll();
    }

    void RumbleAll()
    {
        Vector3 newPos = transform.position;
        if (XRumble) newPos.x += GetRumbleFloat(speed, amount);
        if (YRumble) newPos.y += GetRumbleFloat(speed, amount);
        if (ZRumble) newPos.z += GetRumbleFloat(speed, amount);
        transform.position = newPos;
    }

    float GetRumbleFloat(float speed, float amount)
    {
        return Mathf.Sin(Time.time * speed) * amount;
    }
}
