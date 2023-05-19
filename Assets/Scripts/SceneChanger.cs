using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    //such simple object with simple function in Unity's Component centered game development
    // can still have its merits, as most buttons in hyper casual games is really all about switching 'scenes'. 
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
