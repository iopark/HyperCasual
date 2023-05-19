using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PipeLineSpawner : MonoBehaviour
{
    //주기적으로 생성되는 기능을 만들어주어야한다 => Coroutine 이용 
    //Reflection: 1. This is set apart from the Scrolling functionality, keeping SOLID in line, 
    [SerializeField] private float spawnInterval;
    [SerializeField] private PipeLine pipeLinePrep; // 2. PipeLine, which once generated moves left, this spawner utilizes that 
    [SerializeField] private float randomRange; 
    // 3. as such, OOP takes place where procedural tasks are divided into different objects, and these algorithm can take place horizontally, 
    // 4. if one's able to manage them in seperated objects with divided responsbility. 
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
            Instantiate(pipeLinePrep, spawnPos, transform.rotation);
        }
    }
}
