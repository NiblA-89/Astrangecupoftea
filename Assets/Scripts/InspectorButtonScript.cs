using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(OpenLocation))]
public class InspectorButtonScript : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        OpenLocation openLocation = (OpenLocation)target;
        if (GUILayout.Button("Open Location"))
        {
            openLocation.ActivateLocation();
        }
    }
}
