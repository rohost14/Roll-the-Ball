using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class playAgain : MonoBehaviour
{
    // Start is called before the first frame update
    public void playagainScene()
    {
        yourScore.score = 0;
        CoinCollect.coins += 0; 
        SceneManager.LoadScene("Example Scene");   
    }
}
