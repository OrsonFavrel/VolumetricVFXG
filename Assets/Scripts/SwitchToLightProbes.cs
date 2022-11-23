using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class SwitchToLightProbes : MonoBehaviour
{
    public void Switch()
    {
        var meshRenderers = FindObjectsOfType<MeshRenderer>();
        foreach (MeshRenderer meshRenderer in meshRenderers)
        {
            meshRenderer.receiveGI = ReceiveGI.LightProbes;
        }
    }
}
