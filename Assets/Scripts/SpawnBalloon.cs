using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBalloon : MonoBehaviour
{
    public Transform prefab;
    public int balloon;
    public float yMax;
    public float xMax;

    private void Start ()
    {
        
         Instantiate(prefab, transform.position + new Vector3(0f, Random.Range(xMax, yMax), 0), Quaternion.identity);

    }
}
