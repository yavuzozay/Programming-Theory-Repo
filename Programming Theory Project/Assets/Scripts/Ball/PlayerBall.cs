using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBall : BallBase
{
   public static PlayerBall instance;
    [SerializeField] private GameObject focalPoint;
    private float forwardInput;
    [SerializeField] private GameObject rifle;
    private void Awake()
    {
        instance = this;
        Cache();

    }
    private void Start()
    {
        EventManager.Fire_onPlayerHPChanged(curHP, maxHP);
    }
    void Update()
    {
        
        
        forwardInput = Input.GetAxis("Vertical");
        FireAttack();
        if (curHP <= 0)
        {
            GameManager.Instance.GameOver();

        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            Rigidbody enemyRb = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromPlayer = collision.gameObject.transform.position - transform.position;
            enemyRb.AddForce(awayFromPlayer * 2, ForceMode.Impulse);
            collision.gameObject.GetComponent<EnemyBall>().DecreaseHP(damage);
        }
        
    }
    protected override void Attack()
    {
        
    }
    void FireAttack()
    {
        if (Input.GetKeyDown(KeyCode.Space))

        {
            Vector3 spawnPos = transform.position;


            Instantiate(rifle, spawnPos, Quaternion.Euler(0, 0, 0));
            Instantiate(rifle, spawnPos, Quaternion.Euler(0, 90, 0));
            Instantiate(rifle, spawnPos, Quaternion.Euler(0, 180, 0));
            Instantiate(rifle, spawnPos, Quaternion.Euler(0, 270, 0));
        }
    }

    void Movement()
    {
        rigidbody.AddForce(focalPoint.transform.forward * speed *30* forwardInput * Time.fixedDeltaTime);

    }
    private void FixedUpdate()
    {

        if (GameManager.Instance.isGameActive)
        {
            Movement();
          

        }
        else
        {
            rigidbody.Sleep();
            GameManager.Instance.GameOver();

        }
    }

    public override void DecreaseHP(float damage)
    {
       base.DecreaseHP(damage);
       EventManager.Fire_onPlayerHPChanged(curHP, maxHP);

    }
  

   
   


}
