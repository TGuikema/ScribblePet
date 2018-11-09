using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefaultPositionLayout : MonoBehaviour {
    public Vector3 DefaultPosition = Vector3.zero;
    public Vector3 DefaultScale = new Vector3(.2f, .2f, .2f);
    public void SetPositionForImage(Image image, Vector3 offset)
    {
        image.SetNativeSize();
        image.rectTransform.localPosition = DefaultPosition + offset;
        image.rectTransform.localScale = DefaultScale;      
        image.enabled = true;
    }
}
