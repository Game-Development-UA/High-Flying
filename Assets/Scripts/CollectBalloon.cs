using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectBalloon : MonoBehaviour

{ 
public GameObject balloon;



    void OnTriggerEnter2D(Collision2D collider)
    {
    balloon = collider.gameObject.GetComponent<balloon>;
        if (balloon != null)
        {
        Destroy (balloon);
        }
    }
}
