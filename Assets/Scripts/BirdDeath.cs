using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdDeath : MonoBehaviour
{
    public float lifetime;

    void Start()
    {
        Destroy(this.gameObject, lifetime);    
    }
}
