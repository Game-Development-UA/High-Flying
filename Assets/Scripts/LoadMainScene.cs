using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadMainScene : MonoBehaviour
{
    public void Load (string MainGame)
    {
        SceneManager.LoadScene("MainGame");
    }
}
