using UnityEditor;
using UnityEngine;

namespace DefaultNamespace
{

    
    public class TestEditor : EditorWindow
    {

        public TestStruct MyStruct;
        
        [MenuItem("Window/My Window")]
        static void Init()
        {
            // Get existing open window or if none, make a new one:
            TestEditor window = (TestEditor)EditorWindow.GetWindow(typeof(TestEditor));
            window.titleContent = new GUIContent("Test Window");
            window.Show();
        }

        void OnGUI()
        { 
            SerializedObject so = new SerializedObject(this);
            SerializedProperty myStructProp = so.FindProperty("MyStruct");
            EditorGUILayout.PropertyField(myStructProp);
            so.ApplyModifiedProperties();
            GUILayout.Label("change!");
        }
    }
}
