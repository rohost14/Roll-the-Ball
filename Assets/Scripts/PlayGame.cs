using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour
{
    public void playEasy()
    {
        yourScore.score = 0;
        CoinCollect.coins += 0;
        SceneManager.LoadScene("Example Scene");
    }
}
