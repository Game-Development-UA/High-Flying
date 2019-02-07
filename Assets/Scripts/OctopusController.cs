using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OctopusController : MonoBehaviour
{
    public float speed;
    float horizontal;
    public Rigidbody body;

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
    }

    void FixedUpdate()
    {
        body.AddForce(new Vector2(horizontal * speed, 0f));
    }
}

