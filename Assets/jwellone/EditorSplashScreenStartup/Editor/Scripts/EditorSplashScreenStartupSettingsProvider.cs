using UnityEditor;
using UnityEngine;
using jwellone;

#nullable enable

namespace jwelloneEditor
{
    class EditorSplashScreenStartupSettingsProvider : SettingsProvider
    {
        [SettingsProvider]
        public static SettingsProvider Create()
        {
            return new EditorSplashScreenStartupSettingsProvider("jwellone/EditorSplashScreenStartup")
            {
                label = "EditorSplashScreenStartup",
                keywords = new[] { "jwellone", "EditorSplashScreenStartup" }
            };
        }

        EditorSplashScreenStartupSettingsProvider(string path, SettingsScope scopes = SettingsScope.Project)
            : base(path, scopes)
        {
        }

        public override void OnGUI(string searchContext)
        {
            base.OnGUI(searchContext);

            EditorSplashScreenStartupPrefs.isStartup = GUILayout.Toggle(EditorSplashScreenStartupPrefs.isStartup, "Start when editor is running");
        }
    }
}