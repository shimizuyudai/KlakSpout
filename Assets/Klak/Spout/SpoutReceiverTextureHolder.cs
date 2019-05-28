using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Klak.Spout;
using UtilPack4Unity;

public class SpoutReceiverTextureHolder : TextureHolderBase
{
    [SerializeField]
    SpoutReceiver spoutReceiver;

    public override Texture GetTexture()
    {
        return spoutReceiver.receivedTexture;
    }
}
