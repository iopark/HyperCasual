using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DataManager : MonoBehaviour
{
    //One of the interesting thing about this is that Scoring system, both BestScore and CurrentScore is maintainted through CurScore; 
    [SerializeField]
    private int bestScore;
    public int BestScore {  
        get { return bestScore; } 
        set 
        { 
            if (bestScore != value)
                OnBestScoreChanged?.Invoke(value); // this , as well as CurScore, 
            bestScore = value; 
        }
    }
    public event UnityAction<int> OnBestScoreChanged;
    [SerializeField]
    private int curScore; 

    public int CurScore
    {
        get { return curScore; }
        set
        {
            OnCurScoreChanged?.Invoke(value); // one way to make event invokable is through using Get Set. how crazy is that? 
            // thus, Datamanager soley keeps data: scores, while also becoming 'observer', view , and let 'player' be 'subject', as well as controller it self . 
            curScore = value;

            if (curScore > BestScore)
                BestScore = curScore;// this would callout BestScore 
        }
    }
    public event UnityAction<int> OnCurScoreChanged;
}
