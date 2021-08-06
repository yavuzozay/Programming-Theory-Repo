using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    [SerializeField]private GameObject focalPoint;
    [SerializeField]private float speed;
    private void Awake()
    {
        playerRb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        Movement();
    }
    void Movement()
    {
        float forwardInput = Input.GetAxis("Vertical");
        playerRb.AddForce(focalPoint.transform.forward * speed * forwardInput);
    }
}
