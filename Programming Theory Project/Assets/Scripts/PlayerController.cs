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
    void Update()
    {
        if(GameManager.Instance.isGameActive)
        {
            Movement();

        }
        else
        {
            GameManager.Instance.GameOver();
        }
    }
    void Movement()
    {
        float forwardInput = Input.GetAxis("Vertical");
        playerRb.AddForce(focalPoint.transform.forward * speed * forwardInput);
    }
}
