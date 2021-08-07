using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBoss : Enemy
{
    [SerializeField]EnemyProperties enemyProperties;
    private void Awake()
    {
        //inheritance
        base.speed =enemyProperties.m_speed;
        Declare();

    }

    private void Update()
    {
        //inheritance

        FollowPlayer();
        Debug.Log(gameObject.name + speed);

    }
}
    
