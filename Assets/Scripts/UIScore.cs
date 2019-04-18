using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIScore : MonoBehaviour
{
    public int scoreH;
    public int scoreB;
    public Text heightScore;
    public Text balloonCount;

    private void Start()
    {
        scoreH = 0; 
    }

    void Update()
    {
        scoreH = scoreH + y;
        SetScoreH();
    }

    void SetScoreH()
    {
        heightScore
    }
}
