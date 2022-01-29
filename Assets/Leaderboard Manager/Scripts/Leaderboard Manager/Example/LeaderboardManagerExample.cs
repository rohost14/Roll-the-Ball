using UnityEngine;
using UnityEngine.UI;

namespace CarterGames.Assets.LeaderboardManager
{
    public class LeaderboardManagerExample : MonoBehaviour
    { 
        public Text playerName;
        public Text playerScore;

        public void AddToLB()
        {
            LeaderboardManager.AddToLeaderboard(playerName.text, float.Parse(playerScore.text));
        }


        /*public void RemoveFromLB()
        {
            LeaderboardManager.RemoveEntryFromLeaderboard(playerName.text, float.Parse(playerScore.text));
        }*/
        public void ClearFFromLB()
        {
            LeaderboardManager.ClearLeaderboard();
        }
    }
}