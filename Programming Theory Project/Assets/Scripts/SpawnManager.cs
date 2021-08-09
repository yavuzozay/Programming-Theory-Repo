using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoSingleton<SpawnManager>
{
    [SerializeField] private List<GameObject>enemyPrefabs=new List<GameObject>();
    [SerializeField] private GameObject boss;
    [SerializeField] private GameObject gem;
    [SerializeField] private float xBound;
    [SerializeField] private float zBound;
    private PlayerController playerController;
    private int enemyCount;
    private void Awake()
    {
        GameManager.Instance.level = 1;
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }
    private void Update()
    {
        //Abstraction
        SpawnControl();
    }
    private void SpawnControl()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;
        if (enemyCount == 0)
        {
            GameManager.Instance.level++;
            SpawnEnemyWave(GameManager.Instance.level);
            SpawnObject(gem);

        }
    
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
        else
        {
            for (int i = 0; i <enemiesToSpawn; i++)
            {
                Instantiate(RandomEnemy(), GenerateSpawnPosition(), RandomEnemy().transform.rotation);

            }
            Instantiate(boss, GenerateSpawnPosition(), boss.transform.rotation);

        }
    }

    public void SpawnObject(GameObject obj)
    {
        Instantiate(obj, GenerateSpawnPosition(),obj.transform.rotation);
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
