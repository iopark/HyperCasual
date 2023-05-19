using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSettings
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Init()
    {
        //InitPlatform();
        InitGameManager();
    }

//    private static void InitPlatform()
//    {
//#if UNITY_STANDALONE_WIN
		
//#elif UNITY_ANDROID
//        Application.targetFrameRate = 60;
//#endif
//    }

    private static void InitGameManager()
    {
        if (GameManager.Instance == null)
        {
            GameObject gameManager = new GameObject() { name = "Game Manager" };
            gameManager.AddComponent<GameManager>();
        }
    }
}
