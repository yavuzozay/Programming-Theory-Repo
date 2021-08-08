using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private GameObject player;
    private Rigidbody enemyRb;
    protected float speed=3f;

  
    protected void Declare ()
        {
         player = GameObject.FindGameObjectWithTag("Player");
        enemyRb = GetComponent<Rigidbody>();
        }

    protected void FollowPlayer()
    {
        if(GameManager.Instance.isGameActive)
        {
            Vector3 lookDirection = (player.transform.position - transform.position).normalized;
            enemyRb.AddForce(lookDirection * speed);
        }
       
    }
   protected void FollowPlayer(float speed)
    {
        if (GameManager.Instance.isGameActive)
        {
            Vector3 lookDirection = (player.transform.position - transform.position).normalized;
            enemyRb.AddForce(lookDirection * speed);
        }

    }
}
