using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


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

        if (UIScore.singleton.scoreB == 0 )
        {
            SceneManager.LoadScene("Game Over");

        }
    }
}
