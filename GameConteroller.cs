using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameConteroller : MonoBehaviour
{
    #region public variables
    public int Score { 
        get { return score; }
    }
    public HodTopLefitManager hubbulletManager;
    #endregion
    #region private variable
    private int score;//Score of Player
    #endregion
    #region public method
    public void AddScore(int s)
    {
        if(s > 0)
        {
            score += s;
            hubbulletManager.SetScoreText(score);

        }
    }

    #endregion
    #region praivate method 
    private void Start()
    {
        score = 0;
        hubbulletManager.SetScoreText(score);
    }
    private void Update()
    {
        Debug.Log(score);
    }
    #endregion

}
