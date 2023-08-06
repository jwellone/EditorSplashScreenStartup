#nullable enable

namespace jwellone
{
    public static class EditorSplashScreenStartupPrefs
    {
        const string EDITOR_USER_SETTINGS_KEY_FOR_IS_STARTUP = "EditorSplashScreenStartupPrefs_isStartup";
        const string EDITOR_USER_SETTINGS_KEY_FOR_SCENE_NAME = "EditorSplashScreenStartup_beforeActiveSceneName";

        public static bool isStartup
        {
#if UNITY_EDITOR
            get => UnityEditor.EditorUserSettings.GetConfigValue(EDITOR_USER_SETTINGS_KEY_FOR_IS_STARTUP) == "true";
            set => UnityEditor.EditorUserSettings.SetConfigValue(EDITOR_USER_SETTINGS_KEY_FOR_IS_STARTUP, value ? "true" : "false");
#else
            get;
            set;
#endif
        }

        public static string beforeActiveSceneName
        {
#if UNITY_EDITOR
            get => UnityEditor.EditorUserSettings.GetConfigValue(EDITOR_USER_SETTINGS_KEY_FOR_SCENE_NAME);
            set => UnityEditor.EditorUserSettings.SetConfigValue(EDITOR_USER_SETTINGS_KEY_FOR_SCENE_NAME, value);
#else
            get;
            set;
#endif
        }
    }
}