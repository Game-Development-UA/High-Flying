using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeBalloonMovement : MonoBehaviour
{
    public Transform tballoon;
    public float speed;

    void Update()
    {
        tballoon.position += new Vector3(0f, Time.deltaTime * speed, 0f);
    }
}
