using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player :MonoBehaviour
{
    [SerializeField] private int _health;

    public int health
    {
        get { return _health; }
        set {
            if (_health > 0)
                _health = value;
           
        }
    }
    private void LateUpdate()
    {
        if (_health<=0)
            GameManager.Instance.GameOver();
    }

}
