using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyX : Enemy
{
    [SerializeField]EnemyProperties enemyProperties;
    
    private void Awake()
    {
        //inheritance
        Declare();
        
        
    }

    private void Update()
    {
        //inheritance

        FollowPlayer(enemyProperties.m_speed);
        Debug.Log(gameObject.name + enemyProperties.m_speed);

    }
}
