﻿/*using UnityEngine;
using UnityEditor;


namespace CarterGames.Assets.LeaderboardManager
{
    [CustomEditor(typeof(LeaderboardDisplay))]
    public class LeaderboardDisplayEditor : Editor
    {
        // Reference to LeaderboardDisaply Script
        private LeaderboardDisplay display;


        /// <summary>
        /// Overrides the default inspector for the LeaderboardDisplay Script 
        /// Note: this is not required to use the asset, but make it look a little cleaner xD
        /// </summary>
        public override void OnInspectorGUI()
        {
            // References to the script
            display = (LeaderboardDisplay)target;

            GUILayout.Space(10);

            // Header display * Start *
            EditorGUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();

            // Shows either the Leaderboard Manager Logo or an alternative for if the icon is deleted when you import the package
            if (Resources.Load<Texture2D>("Carter Games/Leaderboard Manager/LogoLBM"))
            {
                if (GUILayout.Button(Resources.Load<Texture2D>("Carter Games/Leaderboard Manager/LogoLBM"), GUIStyle.none, GUILayout.Width(50), GUILayout.Height(50)))
                {
                    GUI.FocusControl(null);
                }
            }
            else
            {
                EditorGUILayout.BeginHorizontal();
                GUILayout.FlexibleSpace();
                EditorGUILayout.LabelField("Leaderboard Display", EditorStyles.boldLabel, GUILayout.Width(150));
                GUILayout.FlexibleSpace();
                EditorGUILayout.EndHorizontal();
            }

            GUILayout.FlexibleSpace();
            EditorGUILayout.EndHorizontal();


            GUILayout.Space(5);
            EditorGUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();
            EditorGUILayout.LabelField("Leaderboard Display", EditorStyles.boldLabel, GUILayout.Width(140));
            GUILayout.FlexibleSpace();
            EditorGUILayout.EndHorizontal();
            GUILayout.Space(10);
            // Header display * End *



            EditorGUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();
            if (GUILayout.Button("Documentation", GUILayout.Width(110f)))
            {
                Application.OpenURL("https://carter.games/leaderboardmanager.html");
            }
           GUI.color = Color.cyan;
            if (GUILayout.Button("Discord", GUILayout.Width(65f)))
            {
                Application.OpenURL("https://carter.games/discord");
            }
            GUI.color = Color.white;
            GUILayout.FlexibleSpace();
            EditorGUILayout.EndHorizontal();


            // The test button
            //This button only works when in play mode to check if the leaderboard is correctly loaded the way you want it to (uncomment if you wish to use).
            EditorGUILayout.BeginHorizontal();
            GUILayout.FlexibleSpace();

            if (GUILayout.Button("Test Leaderboard"))
            {
                display.ClearLeaderboard();
                display.UpdateLeaderboardDisplay();
            }

            GUILayout.FlexibleSpace();
            EditorGUILayout.EndHorizontal();


            // Remaining inspector
            GUILayout.Space(10);

            EditorGUILayout.LabelField("References", EditorStyles.boldLabel);

            SerializedProperty displayProp = serializedObject.FindProperty("leaderboardDisplay");
            EditorGUILayout.PropertyField(displayProp, new GUIContent("Display Object:"));

            SerializedProperty rowProp = serializedObject.FindProperty("leaderboardRowPrefab");
            EditorGUILayout.PropertyField(rowProp, new GUIContent("Row Prefab:"));

            GUILayout.Space(10);

            EditorGUILayout.LabelField("Configuration", EditorStyles.boldLabel);

            EditorGUILayout.BeginHorizontal();
            SerializedProperty showAmountProp = serializedObject.FindProperty("showSpecificAmount");
            EditorGUILayout.LabelField("Show Specific Number Of Entries:", GUILayout.MinWidth(195));
            EditorGUILayout.PropertyField(showAmountProp, new GUIContent(""));
            serializedObject.ApplyModifiedProperties();
            EditorGUILayout.EndHorizontal();

            if (showAmountProp.boolValue)
            {
                SerializedProperty numberToShowProp = serializedObject.FindProperty("numberToShow");
                EditorGUILayout.PropertyField(numberToShowProp, new GUIContent("Number To Show:"));
            }

            GUILayout.Space(10);

            EditorGUILayout.LabelField("Layout Options", EditorStyles.boldLabel);

            SerializedProperty optionProp = serializedObject.FindProperty("displayChoice");
            EditorGUILayout.PropertyField(optionProp, new GUIContent("Order:"));
            serializedObject.ApplyModifiedProperties();
            serializedObject.Update();
        }
    }
}*/