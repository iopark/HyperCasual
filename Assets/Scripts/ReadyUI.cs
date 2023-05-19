using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadyUI : MonoBehaviour
{
    //Reflection: Attempt to seperate Model/View/Controller; This case, seperating Controller apart from the view. 
    [SerializeField] private GameSceneFlow flow; // GameSceneFlow ���������� 
    //�̷��� 1���� �Լ��� ���°�쿡�� �����ϰ� ������ ȣ���ϴ�. 
    private void OnPlay()
    {
        Debug.Log("pressed click"); 
        flow.Play();
    }
}
