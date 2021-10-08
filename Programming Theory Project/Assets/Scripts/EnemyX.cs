using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyX : Enemy
{
   
    
    private  void Awake()
    { 
        Declare();

    }
    private void FixedUpdate()
    {
        FollowPlayer();
    }

  
}
