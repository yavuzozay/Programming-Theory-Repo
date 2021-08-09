using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBoss : Enemy
{
    [SerializeField]EnemyProperties enemyProperties;
    private void Awake()
    {
        base.damage = 10;
        //inheritance
        base.speed =enemyProperties.m_speed;
        Declare();

    }
    //Polymorphism
    protected override void DealDamage(int damage)
    {
        base.DealDamage(damage);
    }
    private void Update()
    {
        //inheritance

        FollowPlayer();
      

    }

  
}
    
