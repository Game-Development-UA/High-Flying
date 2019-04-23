using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIScore : MonoBehaviour
{
    public float scoreH;
    public int scoreB;
    public TextMeshProUGUI heightScore;
    public TextMeshProUGUI balloonCount;

    public static UIScore singleton;

    private void Awake()
    {
        singleton = this;
    }

    private void Start()
    {
        scoreH = 0; 
    }

    void Update()
    {
        scoreH = scoreH + OctopusController.singleton.transform.position.y;
        SetScoreH();
    }

    void SetScoreH()
    {
        heightScore.text = ((int)scoreH).ToString();
    }

    public void SetScoreB(int amountToAdd)
    {
        scoreB = scoreB + amountToAdd;
        balloonCount.text = scoreB.ToString();
    }
}
