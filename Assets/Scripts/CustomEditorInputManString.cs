using UnityEditor;
using UnityEngine;


[CustomEditor(typeof(InputManagerU))]
public class CustomEditorInputManString : Editor
{
    InputManagerU arduiInput;
    private void OnEnable()
    {
        arduiInput = (InputManagerU)target;
    }

    public override void OnInspectorGUI()
    {

        DrawDefaultInspector();
        if (GUILayout.Button("Add Input"))
        {
            arduiInput.OnAddInput();
        }
    }
}


