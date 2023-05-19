using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PipeLineSpawner : MonoBehaviour
{
    //주기적으로 생성되는 기능을 만들어주어야한다 => Coroutine 이용 
    [SerializeField] private float spawnInterval;
    [SerializeField] private PipeLine pipeLinePrep;
    [SerializeField] private float randomRange; 

    private Coroutine spawnRoutine;

    private void OnEnable()
    {
        spawnRoutine = StartCoroutine(SpawnRoutine()); 
    }

    private void OnDisable()
    {
        StopCoroutine(spawnRoutine);
    }
    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);
            Vector2 spawnPos = transform.position + Vector3.up * Random.Range(-randomRange, randomRange);
            Instantiate(pipeLinePrep, spawnPos, Quaternion.identity);
        }
    }
}
