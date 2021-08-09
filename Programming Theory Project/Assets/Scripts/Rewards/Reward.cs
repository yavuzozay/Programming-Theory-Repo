using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reward : MonoBehaviour
{
    protected int point;

    protected virtual void IncreaseScore()
    {
        GameManager.Instance.score += point;
    }
    protected virtual void IncreaseScore(int value)
    {
        GameManager.Instance.score += value;
    }
  

}
