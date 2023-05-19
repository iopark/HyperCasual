using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeLine : MonoBehaviour
{
    [SerializeField] private float moveSpeed;

    private void Update()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime); // 1s 단위로 움직임을 구현함으로써 원하는 속력을 설정할수 있게된다. 
    }
}
