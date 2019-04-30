using UnityEditor;
using UnityEngine;

namespace Assets.Scripts
{
    public class HelloWorld
    {
        [MenuItem("GameObject/Create Hello World!")]
        private static void CreateHelloWorldObject()
        {
            if (EditorUtility.DisplayDialog("Hello World", "Do you really want to do this?", "OK", "Cancel"))
            {
                new GameObject("Hello World");
            }
        }
    }
}