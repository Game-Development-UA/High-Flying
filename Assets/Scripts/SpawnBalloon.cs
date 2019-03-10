using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBalloon : MonoBehaviour
{
    float timer;
    public Transform prefab;
    public float delay;
    public int balloon;
    public float yMax;

    private void Update ()
    {
        timer += Time.deltaTime;

        if (timer > delay)
        {
            for (int i = 0; i < balloon; i++)
            {
                Instantiate(prefab, transform.position + new Vector3(i * 2.0F, Random.Range(0, yMax), 0), Quaternion.identity);
            }

            timer = 0;
        }

    }
}
