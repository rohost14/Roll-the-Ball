using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class displayCoins : MonoBehaviour
{
    public Text finalCoin;

    public void Start()
    {
        
        finalCoin.text = CoinCollect.currentcoin.ToString();
    }
}
