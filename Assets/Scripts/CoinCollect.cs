using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollect : MonoBehaviour
{
    public GameObject explosionPrefab;
    public static int currentcoin;
    public static int coins = 0;
    public Text mainScoreDisplay;
    public GameObject mainCanvas;
    public int value = 10;

    private void Start()
    {
        mainScoreDisplay.text = PlayerPrefs.GetInt("Coins").ToString();
        coins = PlayerPrefs.GetInt("Coins");
    }

    public void collect(int amount)
    {
        currentcoin += amount;
        coins += amount;
        mainScoreDisplay.text = coins.ToString();
        PlayerPrefs.SetInt("Coins", coins);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            collect(value);
            Destroy(gameObject);
        }
       if(explosionPrefab
             != null)
        {
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        }   Destroy(gameObject);
    }
 }

