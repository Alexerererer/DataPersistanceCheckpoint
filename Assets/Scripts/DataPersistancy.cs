using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataPersistancy : MonoBehaviour
{
    public static DataPersistancy Instance;

    public string CurrentPlayerName;
    public string LastPlayerName;
    public int BestScore;

    [System.Serializable]
    class SaveData
    {
        public int SaveScore;
        public string SavePlayerName;
    }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SaveScore(int ScoreToSave, string NameToSave)
    {
        SaveData data = new SaveData();
        data.SaveScore = ScoreToSave;
        data.SavePlayerName = NameToSave;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText("C:\\Users\\Alex\\Documents\\GitHub\\DataPersistanceCheckpoint\\savefile.json", json);
    }

    public void LoadScore()
    {
        string path = "C:\\Users\\Alex\\Documents\\GitHub\\DataPersistanceCheckpoint\\savefile.json";
        if (File.Exists(path))
        {
            
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            LastPlayerName = data.SavePlayerName;
            BestScore = data.SaveScore;
        }
    }

}
