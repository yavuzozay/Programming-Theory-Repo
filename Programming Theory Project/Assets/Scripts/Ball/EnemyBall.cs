using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBall : BallBase
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Rifle"))
        {

            GameManager.Instance.IncreaseScore(1);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
    private void Awake()
    {
        Cache();
    }
    protected override void Attack()
    {
        PlayerBall.instance.DecreaseHP(damage);
        
    }
       void  Update()
    {
        Die();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
            Attack();
    }
    private void FixedUpdate()
    {
        FollowPlayer();
    }
  
    protected void FollowPlayer()
    {
        if (GameManager.Instance.isGameActive)
        {
            Vector3 lookDirection = (PlayerBall.instance.transform.position - transform.position).normalized;
            rigidbody.AddForce(lookDirection * speed);
        }
        else
        {
            rigidbody.Sleep();
        }

    }


}
