using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayFinalhighScore : MonoBehaviour
{
    public Text finalhighSc;

    public void Start()
    {
        finalhighSc.text = /*"Highscore : " +*/ ((int)PlayerPrefs.GetFloat("Highscore")).ToString();
       // finalhighSc.text = ((int)yourScore.highscore).ToString();
        //  final.text = CoinCollect.coins.ToString();
    }
}
