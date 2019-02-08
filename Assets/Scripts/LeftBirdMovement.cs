using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftBirdMovement : MonoBehaviour
{
    public Transform bird;
    public float speed;

    private void Start()
    {
        speed = Random.Range (3f,12f);
    }

    void Update()
    {
        bird.position += new Vector3(Time.deltaTime * speed, 0f, 0f);
    }
}
