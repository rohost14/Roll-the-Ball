using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class displayFinalCoins : MonoBehaviour
{
    public Text finalCoin;
    // Start is called before the first frame update
    void Start()
    {
        finalCoin.text = CoinCollect.currentcoin.ToString();
    }

}
