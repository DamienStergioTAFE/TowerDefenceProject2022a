using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class HighScoreData 
{
    public string levelName;
    public List<float> scores;
    public List<string> names;


    public HighScoreData(string level)
    {
        levelName = level;
        scores = new List<float>();
        names = new List<string>();
    }

}
