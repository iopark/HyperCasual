using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreView : MonoBehaviour
{
    private TMP_Text tmp_text;
    // Reflection: Sole functionality of this pertains to the View in a MVC model, 
    // which is achieved through using Event functionalities 
    // * when trying to utilize Event functionalities to draw lines between each object, 
    // need to plan ahead of the delegate parameter types. 
    // as seen here, if we want updating Score board to stay true as a score board, probably limiting scope of data being used to single parameter of value maybe
    private void Start()
    {
        tmp_text = GetComponent<TMP_Text>();
    }
    private void OnEnable()
    {
        GameManager.Data.OnCurScoreChanged += ChangeScore; 
    }
    private void OnDisable()
    {
        GameManager.Data.OnCurScoreChanged -= ChangeScore;
    }
    private void ChangeScore(int score)
    {
        tmp_text.text = score.ToString();
    }
}
