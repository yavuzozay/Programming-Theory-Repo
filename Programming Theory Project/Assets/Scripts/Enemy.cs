using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private GameObject player;
    private Rigidbody enemyRb;
    protected float speed;
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        enemyRb = GetComponent < Rigidbody>();
    }
    void FollowPlayer()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDirection * speed);

    }
}
