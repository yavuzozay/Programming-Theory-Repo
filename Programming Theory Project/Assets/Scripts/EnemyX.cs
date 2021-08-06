using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyX : Enemy
{
    EnemyProperties enemyProperties;
    
    private void Awake()
    {
        //inheritance
        Declare();
        enemyProperties = new EnemyProperties();
        enemyProperties.speed = 5f;
    }

    private void Update()
    {
        //inheritance

        FollowPlayer(enemyProperties.speed);
        Debug.Log(gameObject.name + enemyProperties.speed);

    }
}
