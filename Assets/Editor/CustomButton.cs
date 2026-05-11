using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

[CustomEditor(typeof(OpenLocation))]
public class CustomButton : Editor
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
