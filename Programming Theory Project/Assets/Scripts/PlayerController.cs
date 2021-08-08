using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    [SerializeField]private GameObject focalPoint;
    [SerializeField]private float speed;
    Player player;
    private void Awake()
    {
        player = GetComponent<Player>();
        playerRb = GetComponent<Rigidbody>();
    }
    public void Attack()
    {
        /*
       if(Input.anyKeyDown)
        {

       
            switch (Input.inputString)
            {
                case "q":
                    Debug.Log("1 pressed");
                    break;
                case "w":
                    Debug.Log("2 pressed");
                    break;
                case "e":
                    Debug.Log("3 pressed");
                    break;
               
            
        }
            }*/
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
