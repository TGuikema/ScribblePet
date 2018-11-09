using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransferImageToMonsterLayout : TransferImage {

    public DefaultPositionLayout DefaultLayout;
    protected override void TransferImageToOtherImage()
    {
        ImageMonster.sprite = ImageToTransfer.sprite;
        DefaultLayout.SetPositionForImage(ImageMonster, Offset);
        //base.TransferImageToOtherImage();
    }
}
