using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(SwitchToLightProbes))]
public class SwitchToLightProbesEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        SwitchToLightProbes script = (SwitchToLightProbes)target;
        if (GUILayout.Button("SwitchToLightProbes"))
        {
            var meshRenderers = FindObjectsOfType<MeshRenderer>();
            script.Switch();
        }
    }
}

