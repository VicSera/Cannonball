using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{

    [SerializeField] private Rigidbody cannonball;
    [SerializeField] private Transform front;
    [SerializeField] private float forceMagnitude;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var frontPos = front.position;
            cannonball.transform.position = frontPos;
            cannonball.velocity = (frontPos - transform.position).normalized * (forceMagnitude / cannonball.mass);
        } 
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down, 1f, Space.World);
        } 
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, 1f, Space.World);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(Vector3.left, 1f, Space.World);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(Vector3.right, 1f, Space.World);
        }
    }
}
