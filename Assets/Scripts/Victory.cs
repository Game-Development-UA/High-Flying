using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D LoadVictory)
    {
        if (LoadVictory.gameObject.CompareTag ("Player"))

            SceneManager.LoadScene("Victory");
    }
}
