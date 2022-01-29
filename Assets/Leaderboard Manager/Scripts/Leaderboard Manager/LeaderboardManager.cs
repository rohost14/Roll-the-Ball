using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Linq;

namespace CarterGames.Assets.LeaderboardManager
{
 
    public class LeaderboardManager : MonoBehaviour
    {
        /// <summary>
        /// Adds a new entry into the leaderboard and saves it.
        /// </summary>
        /// <param name="name">the player name to add with the new entry</param>
        /// <param name="score">the player score to add with the new entry</param>
        public static void AddToLeaderboard(string name, float score)
        {
            string SavePath = Application.persistentDataPath + "/Leaderboard/leaderboardsavefile.lsf";

            if (File.Exists(SavePath))
            {
                LeaderboardStore _storedData = LoadLeaderboardStore();
                _storedData.leaderboardData.Add(new LeaderboardData(name, score));
                BinaryFormatter Formatter = new BinaryFormatter();
                FileStream Stream = new FileStream(SavePath, FileMode.OpenOrCreate);
                Formatter.Serialize(Stream, _storedData);
                Stream.Close();
            }
            else
            {
                SaveLeaderboardStore(new LeaderboardStore());
                LeaderboardStore _storedData = new LeaderboardStore();
                _storedData.leaderboardData.Add(new LeaderboardData(name, score));
                BinaryFormatter Formatter = new BinaryFormatter();
                FileStream Stream = new FileStream(SavePath, FileMode.OpenOrCreate);
                Formatter.Serialize(Stream, _storedData);
                Stream.Close();
                Debug.LogWarning("* Leaderboard Manager * | Warning Code 1 | No file, creating one.");
            }
        }



      /*  /// <param name="playerName">(String) the players name to check for</param>
        /// <param name="playerScore">(Float) the player score to check for</param>
        public static void RemoveEntryFromLeaderboard(string playerName, float playerScore)
        {
            LeaderboardStore _store = LoadLeaderboardStore();

            for (int i = 0; i < _store.leaderboardData.Count; i++)
            {
                if (_store.leaderboardData[i].playerName.Equals(playerName) && _store.leaderboardData[i].playerScore.Equals(playerScore))
                {
                    _store.leaderboardData.RemoveAt(i);
                    break;
                }
            }

            SaveLeaderboardStore(_store);
        }*/


        /// <summary>
        /// Saves the leaderboard store into the save file.
        /// Also checks to see if the leaderboard directory exsists in your games default save location
        /// </summary>
        /// <param name="_storedData">LeaderboardStore to save in the file</param>
        public static void SaveLeaderboardStore(LeaderboardStore _storedData)
        {
            string SavePath = Application.persistentDataPath + "/Leaderboard/leaderboardsavefile.lsf";

            if (File.Exists(SavePath))
            {
                BinaryFormatter Formatter = new BinaryFormatter();
                FileStream Stream = new FileStream(SavePath, FileMode.OpenOrCreate);
                Formatter.Serialize(Stream, _storedData);
                Stream.Close();
            }
            else
            {
                if (!Directory.Exists(Application.persistentDataPath + "/Leaderboard"))
                {
                    Directory.CreateDirectory(Application.persistentDataPath + "/Leaderboard");
                    BinaryFormatter Formatter = new BinaryFormatter();
                    FileStream Stream = new FileStream(SavePath, FileMode.OpenOrCreate);
                    Formatter.Serialize(Stream, _storedData);
                    Stream.Close();
                }
                else
                {
                    BinaryFormatter Formatter = new BinaryFormatter();
                    FileStream Stream = new FileStream(SavePath, FileMode.OpenOrCreate);
                    Formatter.Serialize(Stream, _storedData);
                    Stream.Close();
                }
            }
        }


        /// <summary>
        /// Loads the saved LeaderboardStore from the save file used for the leaderboard
        /// </summary>
        /// <returns></returns>
        public static LeaderboardStore LoadLeaderboardStore()
        {
            string SavePath = Application.persistentDataPath + "/Leaderboard/leaderboardsavefile.lsf";

            if (File.Exists(SavePath))
            {
                BinaryFormatter Formatter = new BinaryFormatter();
                FileStream Stream = new FileStream(SavePath, FileMode.Open);

                LeaderboardStore _data = Formatter.Deserialize(Stream) as LeaderboardStore;

                Stream.Close();

                return _data;
            }
            else
            {
                Debug.LogError("* Leaderboard Manager * | Error Code 1 | Leaderboard save file not found!");
                return null;
            }
        }


        /// <summary>
        /// Loads the saved LeaderboardData from the save file used for the leaderboard
        /// </summary>
        /// <returns></returns>
        public static LeaderboardData[] LoadLeaderboardData()
        {
            string SavePath = Application.persistentDataPath + "/Leaderboard/leaderboardsavefile.lsf";

            if (File.Exists(SavePath))
            {
                BinaryFormatter Formatter = new BinaryFormatter();
                FileStream Stream = new FileStream(SavePath, FileMode.Open);

                LeaderboardStore _data = Formatter.Deserialize(Stream) as LeaderboardStore;

                Stream.Close();

                return _data.leaderboardData.ToArray();
            }
            else
            {
                Debug.LogError("* Leaderboard Manager * | Error Code 1 | Leaderboard save file not found!");
                return null;
            }
        }


        /// <summary>
        /// Loads the leaderboard values in a decesnding order based on the players scores.
        /// </summary>
        /// <returns>(Array of LeaderboardData) Entries in the save file ordered by score</returns>
        public static LeaderboardData[] LoadLeaderboardDataDescending()
        {
            string SavePath = Application.persistentDataPath + "/Leaderboard/leaderboardsavefile.lsf";

            if (File.Exists(SavePath))
            {
                BinaryFormatter Formatter = new BinaryFormatter();
                FileStream Stream = new FileStream(SavePath, FileMode.Open);
                LeaderboardStore _store = Formatter.Deserialize(Stream) as LeaderboardStore;
                Stream.Close();

                List<LeaderboardData> _array = new List<LeaderboardData>();
                _array = _store.SortedLBD.ToList();
                _array.Reverse();

                return _array.ToArray();
            }
            else
            {
                Debug.LogError("* Leaderboard Manager * | Error Code 1 | Leaderboard save file not found!");
                return null;
            }
        }


        /// <summary>
        /// Loads the leaderboard values in a ascending order based on the players scores.
        /// </summary>
        /// <returns>(Array of LeaderboardData) Entries in the save file ordered by score</returns>
        public static LeaderboardData[] LoadLeaderboardDataAscending()
        {
            string SavePath = Application.persistentDataPath + "/Leaderboard/leaderboardsavefile.lsf";

            if (File.Exists(SavePath))
            {
                BinaryFormatter Formatter = new BinaryFormatter();
                FileStream Stream = new FileStream(SavePath, FileMode.Open);
                LeaderboardStore _store = Formatter.Deserialize(Stream) as LeaderboardStore;
                Stream.Close();

                List<LeaderboardData> _array = new List<LeaderboardData>();
                _array = _store.SortedLBD.ToList();

                return _array.ToArray();
            }
            else
            {
                Debug.LogError("* Leaderboard Manager * | Error Code 1 | Leaderboard save file not found!");
                return null;
            }
        }


       
        /// Clears the leaderboard data at the file level.
       
        public static void ClearLeaderboard()
        {
            string SavePath = Application.persistentDataPath + "/Leaderboard/leaderboardsavefile.lsf";
            LeaderboardStore _storedData = new LeaderboardStore();

            if (File.Exists(SavePath))
            {
                BinaryFormatter Formatter = new BinaryFormatter();
                FileStream Stream = new FileStream(SavePath, FileMode.OpenOrCreate);
                Formatter.Serialize(Stream, _storedData);
                Stream.Close();
            }
            else
            {
                if (!Directory.Exists(Application.persistentDataPath + "/Leaderboard"))
                {
                    Directory.CreateDirectory(Application.persistentDataPath + "/Leaderboard");
                    BinaryFormatter Formatter = new BinaryFormatter();
                    FileStream Stream = new FileStream(SavePath, FileMode.OpenOrCreate);
                    Formatter.Serialize(Stream, _storedData);
                    Stream.Close();
                }
                else
                {
                    BinaryFormatter Formatter = new BinaryFormatter();
                    FileStream Stream = new FileStream(SavePath, FileMode.OpenOrCreate);
                    Formatter.Serialize(Stream, _storedData);
                    Stream.Close();
                }
            }
        }
    }
}