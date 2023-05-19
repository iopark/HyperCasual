using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    private static DataManager dataManager;
    public static GameManager Instance
    {
        get { return instance; }
    }
    public static DataManager Data
    {
        get { return dataManager;}
    }
    /// <summary>
    /// Singleton utilizing component functions in the Unity 
    /// </summary>
    private void Awake()
    {
        if (instance != null)
        {
            Debug.Log("Following SingleTon Material has been listed Already");
            Destroy(this);
            return;
        }
        instance = this;
        DontDestroyOnLoad(this); 
        SetManagers();
    }
    private void OnDestroy()
    {
        if (instance == null)
            instance = null;
    }

    private void SetManagers()
    {
        GameObject dataObj = new GameObject() { name = "Data Managers" };
        dataObj.transform.SetParent(transform); 
        dataManager = dataObj.AddComponent<DataManager>();
    }
}
