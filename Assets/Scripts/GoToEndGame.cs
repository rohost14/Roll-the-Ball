using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GoToEndGame : MonoBehaviour
{
    public void endGame()
    {
        SceneManager.LoadScene("EndGameScene");
    }
        

}
