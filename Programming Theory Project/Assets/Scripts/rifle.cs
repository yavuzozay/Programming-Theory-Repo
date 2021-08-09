using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rifle : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] GameObject player;
    private float bound=30;
    private void Update()
    {
        Movement();
        DestroyRiffles();
    }
    void Movement()
    {

        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
    void DestroyRiffles()
    {
        if (transform.position.x < -bound || transform.position.x > bound || transform.position.z < -bound || transform.position.z > bound)
            Destroy(gameObject);
    }
   
}
