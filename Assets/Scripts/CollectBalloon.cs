using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectBalloon : MonoBehaviour
    //add to Octopus not Ballon

{ 
public GameObject balloon;



    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.name == "Balloon")
        {
        Destroy (this.gameObject);
        }
    }
}
