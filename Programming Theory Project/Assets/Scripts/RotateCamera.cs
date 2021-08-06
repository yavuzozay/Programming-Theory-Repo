using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    [SerializeField] private float rotateSpeed;
    private GameObject player;
    [SerializeField] Vector3 offset;
    
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    private void LateUpdate()
    {
        Rotate();
        FollowPlayer();
    }

   private void FollowPlayer()

    {
        transform.position = player.transform.position + offset;

    }
    void Rotate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime*horizontalInput);
    }
}
