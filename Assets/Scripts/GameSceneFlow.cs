using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameSceneFlow : MonoBehaviour
{
    [SerializeField] private State curState;

    public UnityEvent OnReady;
    public UnityEvent OnPlay;
    public UnityEvent OnGameOver;

    private void Start()
    {
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
