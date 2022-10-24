using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameConteroller : MonoBehaviour
{
    #region public variables
    public int Score { 
        get { return score; }
    }
    public HodTopLefitManager hodTopLefitManager ;
    public HubbulletManager hubbulletManager;
    public CoinReposeitory coinrepo;
    public ScoreReposetory scorerepo;
    public ShipReposetory shiprepo;
    #endregion
    #region private variable
    private int score;//Score of Player
    private int bullet=100;//bullets 
    private int coins = 0;

    #endregion
    #region public method
    public void AddScore(int s)
    {
        if(s > 0)
        {
            score += s;
            hodTopLefitManager.SetScoreText(score);

        }
    }
    public bool HasBullet()
    {
        if (bullet > 0) return true;
         return false;
    }
    public void PopBullet()
    {
        bullet = bullet - 1;
        hubbulletManager.Setbullet(bullet);
    }
    public void AddCoin()
    {
        coins += 1;

    }

    #endregion
    #region praivate method 
    private void Start()
    {
        Instantiate(shiprepo.GetCurrentShip(), Vector3.zero, Quaternion.identity);

        score = 0;
        bullet = 100;
        coins = 0;
        hodTopLefitManager.SetScoreText(score);
        hubbulletManager.Setbullet(bullet);
        Debug.Log("last Score is" + scorerepo.GetLastScore() + "And HightScore" + scorerepo.GetHightScore());
    }

    private void Update()
    {
       // Debug.Log(coins.ToString());
       
    }
    private void OnApplicationQuit()
    {
        /*        coins = coins + PlayerPrefs.GetInt("coin");  
                PlayerPrefs.SetInt("coin", coins);*/
        coinrepo.push(coins);
        scorerepo.push(score);
    }
    #endregion

}
