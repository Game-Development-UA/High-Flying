using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PHFishMovement : MonoBehaviour
{
    public Transform propfish;
    private bool saw = true;
    public float speed;

    void Update()
    {
        propfish.position += new Vector3(0f, Time.deltaTime * speed, 0f);

        if (saw)
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        else
            transform.Translate(-Vector3.right * speed * Time.deltaTime);

        //adjust y <,> values depending on Airplane's start position.

      /*  if (transform.position.y >= 2.0f)
        {
            saw = true;
        }

        if (transform.position.y <= -1.0f)
        {
            saw = false;
        } */
    }
}
