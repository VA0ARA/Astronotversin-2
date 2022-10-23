using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinReposeitory : MonoBehaviour
{
    #region private variable
    private int coins;
    public string ReposetoryName { get { return reposetoryName; } }
    #endregion
    #region public variable
    #endregion
    #region const variable
    private const string reposetoryName= "coinReposetory";
    #endregion
    #region private Method
    private bool Has(int count)
    {
        if (coins >= count)
        {
            return true;
        }
        return false;
    }
    private void Start()
    {
        if (PlayerPrefs.HasKey(reposetoryName))
        {
            coins = Retrive();
        }
        else { coins = 0; }
    }
    //call int  reposetoryName
    private int Retrive()
    {
        return PlayerPrefs.GetInt(reposetoryName);
    }
    //intialaize .....coin and key
    private void Saverepo()
    {
        PlayerPrefs.SetInt(reposetoryName, coins);

    }
    #endregion
    #region public Method
    public bool Pop(int count)
    {
        if (Has(count))
        {
            coins = coins - count;
            Saverepo();
            return true;
        }
        else
        {
            return false;
        }
        

    }
    public int Get()
    {
        return coins;
    }
    public void  push(int count )
    {
        if (count > 0)
        {
            coins = coins + count;
            Saverepo();
        }
        

    }
    public void Save()
    {
        Saverepo();

    }
    #endregion

}
