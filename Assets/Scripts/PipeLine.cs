using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeLine : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    //Reflection: Basic Object which contributes further game algorithm in game's main challenge: Conveyor belt of random pipelines. 
    //1. This sets the foundation of that, by solely focusing on the characteristic of pipe itself 

    private void Start()
    {
        Destroy(gameObject, 5f);
    }
    private void Update()
    { //2. The importance of this is that such isolation of responsibility is without any doubt, for sake of completing the build for conveyor belt of pipelines. 
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime); // 1s 단위로 움직임을 구현함으로써 원하는 속력을 설정할수 있게된다. 
    }
}
