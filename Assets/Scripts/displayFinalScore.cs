using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class displayFinalScore : MonoBehaviour
{
    public Text finalSc;
    
    public void Start()
    {
        finalSc.text = ((int)yourScore.score).ToString();
      //  final.text = CoinCollect.coins.ToString();
    }
}
/*
 * public class displayFinalhighScore : MonoBehaviour
{
    public Text finalhighSc;
    
    public void Start()
    {
        finalhighSc.text = ((int)yourScore.highscore).ToString();
      //  final.text = CoinCollect.coins.ToString();
    }
} */