using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreReposetory : MonoBehaviour
{
    #region private variable

    #endregion
    #region const variable
    private const string LastScoreReposetory = "LastScoreReposetory";
    private const string HighScoreReposetory = "HighScoreReposetory";
    #endregion
    #region private Method
    private int Retrive(string key)
    {
        return PlayerPrefs.GetInt(key);
    }
    private void Save(string key, int val)
    {
        PlayerPrefs.SetInt(key, val);
    }
    #endregion
    #region public Method
    public void push(int s)
    {
        Save(LastScoreReposetory,s);
        int h = GetHightScore();
        if (s > h)
        {
            Save(HighScoreReposetory, s);
        }

    }
    public int GetLastScore()
    {
        return Retrive(LastScoreReposetory) ;
    }
    public int GetHightScore()
    {
        return Retrive(HighScoreReposetory);
    }
    #endregion

}
