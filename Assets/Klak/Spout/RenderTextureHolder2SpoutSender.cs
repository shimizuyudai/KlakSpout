using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UtilPack4Unity;
using Klak.Spout;

public class RenderTextureHolder2SpoutSender : MonoBehaviour
{
    [SerializeField]
    RenderTextureHolder renderTextureHolder;
    [SerializeField]
    SpoutSender spoutSender;

    // Start is called before the first frame update
    void Start()
    {
        spoutSender.externalControl = true;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        var tex = renderTextureHolder.GetRenderTexture();
        if (tex == null) return;
        spoutSender.SendRenderTexture(tex);
    }
}
