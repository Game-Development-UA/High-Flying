using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OctopusController : MonoBehaviour
{
    public float speed;
    float horizontal;
    float vertical;
    public Rigidbody2D body;

    public static OctopusController singleton;

    private void Awake()
    {
        singleton = this;
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        body.velocity=(new Vector2(horizontal * speed, vertical * speed));

    }
}

