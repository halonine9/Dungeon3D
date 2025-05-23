using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public float jumpForce = 100f;
    public Vector3 jumpDirection = Vector3.up;
    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody rigid = collision.collider.GetComponent<Rigidbody>();

        if (rigid != null)
        {
            Vector3 force = jumpDirection.normalized * jumpForce;
            Vector3 velocity = rigid.velocity;
            velocity.y = 0;
            rigid.velocity = velocity;
            
            rigid.AddForce(force, ForceMode.Impulse);
        }
    }
}
