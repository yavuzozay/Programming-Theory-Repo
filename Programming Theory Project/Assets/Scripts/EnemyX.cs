using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyX : Enemy
{
    [SerializeField]EnemyProperties enemyProperties;
    
    private  void Awake()
    {
        base.damage = 4;
        base.speed = enemyProperties.m_speed;
        //inheritance
        Declare();
        
        
    }
    protected override void Attack()
    {

        base.Attack();
    }

    private void Update()
    {
       

        FollowPlayer();
      
       

    }
}
