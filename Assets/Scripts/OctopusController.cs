using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OctopusController : MonoBehaviour
{
    public float horizontal;
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
    }
}
