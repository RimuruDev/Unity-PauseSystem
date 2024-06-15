using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using AbyssMoth.Plugins.UnityPauseSystem.Core;

namespace AbyssMoth.Plugins.UnityPauseSystem.Editor
{
    public static class PauseSystemEditor
    {
        [MenuItem("RimuruDev Tools/Add Pause System")]
        public static void AddPauseSystem()
        {
            var pauseSystem = Object.FindObjectOfType<PauseSystem>(true);

            if (pauseSystem == null)
            {
                var gameObject = new GameObject("[ === PauseSystem === ]");
                gameObject.AddComponent<PauseSystem>();

                SceneManager.MoveGameObjectToScene(gameObject, SceneManager.GetActiveScene());

                Selection.activeObject = gameObject;
            }
            else
            {
                Debug.LogWarning("PauseSystem уже существует на сцене.");
            }
        }
    }
}