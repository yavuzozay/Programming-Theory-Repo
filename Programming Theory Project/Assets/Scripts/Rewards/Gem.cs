using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : Reward
{
    private void Awake()
    {
        base.point = 10;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            IncreaseScore();
            Destroy(gameObject);
        }

    }
}
