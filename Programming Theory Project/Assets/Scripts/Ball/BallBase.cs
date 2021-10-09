using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BallBase : MonoBehaviour
{
    protected Rigidbody rigidbody;
   [SerializeField] protected float maxHP;
     protected float curHP;
    [Range(-10, 10)]
    [SerializeField] protected float speed;
    [SerializeField] protected int damage;
   public virtual void DecreaseHP(float damage)
    {
        curHP -= damage;
        if (curHP <= 0)
            curHP = 0;
    }
    protected void Cache()
    {
        rigidbody = GetComponent<Rigidbody>();
        curHP = maxHP;
    }
   
    protected virtual void Die()
    {
        if (curHP <= 0)
            Destroy(gameObject);
    }
  
    protected abstract void Attack();
 
}
