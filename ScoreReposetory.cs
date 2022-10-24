using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreReposetory : MonoBehaviour
{
    #region private variable
    private int coins;
    public string ReposetoryName { get { return reposetoryName; } }
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
    public void push()
    {

    }
    #endregion

}
