using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private List<GameObject>enemyPrefabs=new List<GameObject>();
    [SerializeField] private float xBound;
    [SerializeField] private float zBound;
    private int enemyCount;
    private void Awake()
    {
        SpawnEnemyWave(2);   
    }
    public void SpawnEnemyWave(int enemiesToSpawn)
    {
        if(enemiesToSpawn<3)
        {
            for (int i = 0; i < enemiesToSpawn; i++)
            {
                Instantiate(RandomEnemy(), GenerateSpawnPosition(), RandomEnemy().transform.rotation);
            }
        }
    }

    private GameObject RandomEnemy()
    {
        int index = Random.Range(0, enemyPrefabs.Count);
        return enemyPrefabs[index];
    }
    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX=Random.Range(-xBound,xBound);
        float spawnPosZ=Random.Range(-zBound,zBound);
        return new Vector3(spawnPosX,0,spawnPosZ);
    }

}
