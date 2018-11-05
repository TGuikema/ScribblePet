using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TransferImage : MonoBehaviour {



    //public Button ButtonImageToTransfer;
    public Image ImageToTransfer;
    public Image ImageMonster;

    public GameObject ConfirmMessage;

    private void Reset()
    {
        ImageToTransfer = GetComponent<Image>();
    }

    private void Start()
    { 
        //TransferImageToOtherImage();
    }
    private void OnEnable()
    {
        
    }
    private void OnDisable()
    {
        
    }

    public void SolveButtonClick()
    {

        ActivateConfirmMessages();
        TransferImageToOtherImage();

    }

    private void ActivateConfirmMessages()
    {
        ConfirmMessage.SetActive(true);
    }

    private void TransferImageToOtherImage()
    {
        /*if (ImageToTransfer.sprite == ImageMonster.sprite)
        {
            ImageMonster.sprite = null;
            ImageMonster.enabled = false;         
            return;
        }*/
        ImageMonster.sprite = ImageToTransfer.sprite;
        ImageMonster.enabled = true;
   
    }



}
