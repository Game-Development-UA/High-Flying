using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LoadScores : MonoBehaviour
{
    public float heightSaved;
    public int balloonCountSaved;
    public TextMeshProUGUI heightScore;
    public TextMeshProUGUI balloonCount;

    private void Start()
    {
        SetHeightText();
        SetBalloonText();
        SetScoreH();
        SetScoreB();
    }

    void SetHeightText()
    {
        heightSaved = PlayerPrefs.GetFloat("HeightScore", UIScore.singleton.scoreH);
    }

    void SetBalloonText()
    {
        balloonCountSaved = PlayerPrefs.GetInt("BalloonCount", UIScore.singleton.scoreB);
    }

    void SetScoreH()
    {
        heightScore.text = ((int)heightSaved).ToString();
    }

    void SetScoreB()
    {
        balloonCount.text = balloonCountSaved.ToString();
    }

}
