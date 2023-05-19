using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadyUI : MonoBehaviour
{
    [SerializeField] private GameSceneFlow flow; 

    private void OnPlay()
    {
        Debug.Log("pressed click"); 
        flow.Play();
    }
}
