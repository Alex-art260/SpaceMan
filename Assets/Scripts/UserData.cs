using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class UserData : MonoBehaviour
{ 
    public HighScore highScore;

    public void LoadField()
    {
        highScore = JsonUtility.FromJson<HighScore>(File.ReadAllText(Application.persistentDataPath + "/SaveData.json"));
    }

    public void SaveField()
    {
        File.WriteAllText(Application.persistentDataPath + "/SaveData.json", JsonUtility.ToJson(highScore));
    }
}

[System.Serializable]
public class HighScore
{
    public int highScore;
}

