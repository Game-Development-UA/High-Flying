using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Balloon")
        {
            Destroy(collision.gameObject);
            UIScore.singleton.SetScoreB(-1);
        }

        if (collision.gameObject.name == "Balloon(Clone)")
        {
            Destroy(collision.gameObject);
            UIScore.singleton.SetScoreB(-1);
        }
    }
}
