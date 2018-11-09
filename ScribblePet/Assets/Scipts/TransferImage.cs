using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TransferImage : MonoBehaviour {



    //public Button ButtonImageToTransfer;
    public Image ImageToTransfer;
    public Image ImageMonster;

    public GameObject ConfirmMessage;

    protected virtual void Reset() { ImageToTransfer = GetComponent<Image>(); }
    protected virtual void Start() { }
    protected virtual void OnEnable() { }
    protected virtual void OnDisable() { }

    public virtual void SolveButtonClick()
    {

        ActivateConfirmMessages();
        TransferImageToOtherImage();

    }

    protected virtual void ActivateConfirmMessages()
    {
        ConfirmMessage.SetActive(true);
    }

    public Vector3 NewSize = new Vector3(0.2f, 0.2f, 0.2f);
    public Vector3 Offset = new Vector3(0, 0, 0);

    protected virtual void TransferImageToOtherImage()
    {
        /*if (ImageToTransfer.sprite == ImageMonster.sprite)
        {
            ImageMonster.sprite = null;
            ImageMonster.enabled = false;         
            return;
        }*/
        ImageMonster.sprite = ImageToTransfer.sprite;
        ImageMonster.SetNativeSize();
        ImageMonster.rectTransform.localScale = NewSize;
        ImageMonster.rectTransform.localPosition = Offset;
        ImageMonster.enabled = true;
   
    }
}
