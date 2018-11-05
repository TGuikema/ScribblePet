using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageUI : MonoBehaviour {

    public Image ImageOwn;
    public Image ImageRef; 

    private void Update()
    {
        ChangeImageIfChanged();
    }

    private void ChangeImageIfChanged()
    {
        if (ImageOwn.sprite != ImageRef.sprite)
            ImageOwn.sprite = ImageRef.sprite;
    }

}
