using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class goToScoreboard : MonoBehaviour
{
    public void Scorecard()
    {
        SceneManager.LoadScene("LeaderboardManagerExampleScene");
    }


}