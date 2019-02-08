using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirplaneMovement : MonoBehaviour
{
    public Transform airplane;
    private bool saw = true;
    public float speed;

    private void Start()
    {
        speed = Random.Range(3f, 8f);
    }

    void Update()
    {
        airplane.position += new Vector3(Time.deltaTime * speed, 0f, 0f);

        if (saw)
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        else
            transform.Translate(-Vector3.up * speed * Time.deltaTime);

        //adjust y <,> values depending on Airplane's start position.

        if (transform.position.y > 5.0f)
        {
            saw = false;
        }

        if (transform.position.y <= 4.0f)
        {
            saw = true;
        }
    }
}
