using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveScores : MonoBehaviour
{
     void Update()
    {
        PlayerPrefs.SetFloat("heightScore", UIScore.singleton.scoreH);
        PlayerPrefs.SetInt("balloonCount", UIScore.singleton.scoreB);
    }
}
