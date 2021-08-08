using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player :MonoBehaviour
{
    [SerializeField] private int _health;

    public int health
    {
        get { return _health; }
        set { _health = value; }
    }
    

}
