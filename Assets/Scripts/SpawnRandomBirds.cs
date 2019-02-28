using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandomBirds : MonoBehaviour
{
    float timer;
    public Transform prefab;

    public float delay;
    public int numBirds;

    public float yMax;

    private void Update()
    {
        timer += Time.deltaTime;

        if( timer > delay )
        {
            for(int i = 0; i < numBirds; i++)
            {
                Instantiate(prefab, transform.position + new Vector3(i * 2.0F, Random.Range(0f, yMax), 0), Quaternion.identity);
            }

            timer = 0;
        }

    }
}
