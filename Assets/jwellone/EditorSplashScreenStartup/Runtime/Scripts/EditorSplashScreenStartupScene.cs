using System.Collections;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

#nullable enable

namespace jwellone
{
    public sealed class EditorSplashScreenStartupScene : MonoBehaviour
    {
        IEnumerator Start()
        {
            SplashScreen.Begin();

            while (!SplashScreen.isFinished)
            {
                yield return null;
            }

            SceneManager.LoadScene(EditorSplashScreenStartupPrefs.beforeActiveSceneName);
        }

        void OnApplicationQuit()
        {
            SplashScreen.Stop(SplashScreen.StopBehavior.StopImmediate);
        }
    }
}