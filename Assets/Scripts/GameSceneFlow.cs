using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameSceneFlow : MonoBehaviour
{
    //Reflection: Now this is the most interesting bit of scripting work done at class. 
    // 1. This is because it is neither the view, Controller, or the Model, 
    // but rather, it's sole responsibility is to mediate users into different stages of the 'system' itself. 
    // The events are used, so dev can use UI to insert functionalities of each stages conviniently(which is really interesting, but makes you wonder if this is good thing for programmer). 
    // * Can I generate a UI that allows anyone to directly add functionalities of different Objects? => this question is probably the reason why it made me think twice about this convenience. 

    [SerializeField] private State curState; // the purpose of this is to use it as part of Debugging method 

    public UnityEvent OnReady;
    public UnityEvent OnPlay;
    public UnityEvent OnGameOver;

    private void Start()
    {
        //Utilizing gameObj's basic EventMessage Function to direct orders of stages. 
        Ready();
        GameManager.Data.CurScore = 0; 
    }
    public void Play() 
    { 
        curState = State.Play; // 외부에서 상태 체크를 위한 최소한의 기능 
        OnPlay?.Invoke();
    }
    public void GameOver() 
    {
        curState = State.GameOver; 
        OnGameOver?.Invoke();
    }
    public void Ready()
    {
        curState = State.Ready; 
        OnReady?.Invoke();
    }
    public enum State
    {
        Ready, 
        Play, 
        GameOver,
    }
}
