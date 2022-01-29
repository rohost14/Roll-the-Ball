using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class yourScore : MonoBehaviour
{   
    public static float score;
    public Text scoreText;
   // public static float highscore; 
    //public Text highscoretext;

    //  public AudioSource collectSound;
     /*void Awake()
    {
        score = 0;
        highscore = PlayerPrefs.GetInt("High Score", 0);//.ToString();
        highscoretext.text = "High Score: "+ highscore;
    }*/
    void Update ()
    {
        score += (Time.deltaTime);
        scoreText.text = ((int)score).ToString();
        // highscoretext.text = "High Score: " + highscore;
        //if(score>highscore)//PlayerPrefs.GetInt("High Score", highscore))
        //{
        //   highscore = score;
        // highscoretext.text = "High Score: " + score;
        //PlayerPrefs.SetFloat("HighScore", highscore);
        //highscoretext.text = ((int)score).ToString();
        //}
        if(PlayerPrefs.GetFloat("Highscore") < score)
        PlayerPrefs.SetFloat("Highscore", score);
    }
    /*void forhighscore()
    {
        if (PlayerPrefs.GetFloat("Highscore") < score)
            PlayerPrefs.SetFloat("Highscore", score);
    }*/
 
}
