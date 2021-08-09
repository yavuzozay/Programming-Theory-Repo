using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    [SerializeField]private GameObject focalPoint;
    [SerializeField]private float speed;
    Player player;
    
    [SerializeField] private GameObject rifle;

 
    private void Awake()
    {
        player = GetComponent<Player>();
        playerRb = GetComponent<Rigidbody>();
    }
     void Attack()
    {

        if (Input.GetKeyDown(KeyCode.Space))
            FireAttack();
        }
    void FireAttack()
    {
        Vector3 spawnPos = transform.position;


        Instantiate(rifle, spawnPos, Quaternion.Euler(0, 0, 0));
        Instantiate(rifle, spawnPos, Quaternion.Euler(0, 90, 0));
        Instantiate(rifle, spawnPos, Quaternion.Euler(0, 180, 0));
        Instantiate(rifle, spawnPos, Quaternion.Euler(0, 270, 0));
    }

    void Update()
    {
        Attack();
        // player.health--;
        if(GameManager.Instance.isGameActive)
        {
            Movement();

        }
        else
        {
            playerRb.Sleep();
            GameManager.Instance.GameOver();

        }
    }
 
    void Movement()
    {
        float forwardInput = Input.GetAxis("Vertical");
        playerRb.AddForce(focalPoint.transform.forward * speed * forwardInput);
    }
}
