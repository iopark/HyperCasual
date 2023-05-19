using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadyUI : MonoBehaviour
{
    //Reflection: Attempt to seperate Model/View/Controller; This case, seperating Controller apart from the view. 
    [SerializeField] private GameSceneFlow flow; // GameSceneFlow 직접참조함 
    //이렇게 1개의 함수만 들어가는경우에는 참조하고 끝내도 호방하다. 
    private void OnPlay()
    {
        Debug.Log("pressed click"); 
        flow.Play();
    }
}
