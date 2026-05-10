using Meatwo310.HideOnUpload;
using UnityEditor;

namespace Meatwo310.HideOnUpload.Editor
{
    [CustomEditor(typeof(HideOnUpload))]
    [CanEditMultipleObjects]
    public sealed class HideOnUploadEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            EditorGUILayout.HelpBox(
                "This GameObject remains visible and editable in Unity, but will be hidden from the uploaded avatar.",
                MessageType.Info);
        }
    }
}
