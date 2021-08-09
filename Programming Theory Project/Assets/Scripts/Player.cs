using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player :MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private int _power;


    //Encapsulation
    public int power
    {
        get { return _power; }
        set { _power = value; }
       
    }
    public int health
    {
        get { return _health; }
        set {
            if (_health > 0)
                _health = value;
           
        }
    }



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Rigidbody enemyRb = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromPlayer = collision.gameObject.transform.position - transform.position;
            enemyRb.AddForce(awayFromPlayer * _power, ForceMode.Impulse);
        }
    }
 
    private void LateUpdate()
    {
        if (_health<=0)
            GameManager.Instance.GameOver();
    }

}
