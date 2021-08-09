using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : Reward
{

    private void Awake()
    {
        base.point = 5;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            IncreaseScore();

        }
    }
}
