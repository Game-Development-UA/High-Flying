using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OctopusController : MonoBehaviour
{
    public float speed;
    float horizontal;
    float vertical;
    public Rigidbody body;

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

    }

    void FixedUpdate()
    {
        body.AddForce(new Vector2(horizontal * speed, 0f));
    }
}

