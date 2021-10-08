using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBoss : Enemy
{
   
    private void Awake()
    {
        Declare();

    }
   
    private void Update()
    {

        FollowPlayer();
      
    }
    void Attack()
    {

    }

  
}
    
