using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectBalloon : MonoBehaviour
    //add to Octopus not Ballon

{ 
public GameObject balloon;


    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.name == "Octopus")
        {
            this.transform.parent = collider.transform;
            this.transform.localPosition = new Vector3(Random.Range(-.5f, .5f), Random.Range(.5f, 1.5f), 0f);
            UIScore.singleton.SetScoreB(1);
        }
    }
}
