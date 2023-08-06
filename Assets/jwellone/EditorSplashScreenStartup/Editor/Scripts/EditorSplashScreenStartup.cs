using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;
using jwellone;

#nullable enable

namespace jwelloneEditor
{
    [InitializeOnLoad]
    static class EditorSplashScreenStartup
    {
        readonly static string SPLASH_SCENE_NAME = "EditorSplashScreenStartup";
        readonly static string SPLASH_SCENE_PATH = $"Assets/jwellone/EditorSplashScreenStartup/Editor/Scenes/{SPLASH_SCENE_NAME}.unity";

        static EditorSplashScreenStartup()
        {
            EditorApplication.playModeStateChanged -= OnPlayModeStateChanged;
            EditorApplication.playModeStateChanged += OnPlayModeStateChanged;
        }

        static void OnPlayModeStateChanged(PlayModeStateChange mode)
        {
            if (mode == PlayModeStateChange.ExitingEditMode)
            {
                if (EditorSplashScreenStartupPrefs.isStartup)
                {
                    EditorSplashScreenStartupPrefs.beforeActiveSceneName = SceneManager.GetActiveScene().name;

                    var asset = AssetDatabase.LoadAssetAtPath<SceneAsset>(SPLASH_SCENE_PATH);
                    EditorSceneManager.playModeStartScene = asset;
                }
            }
            else if (mode == PlayModeStateChange.EnteredEditMode)
            {
                EditorSceneManager.playModeStartScene = null;
            }
        }
    }
}