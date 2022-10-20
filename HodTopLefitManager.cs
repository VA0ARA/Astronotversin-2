using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HodTopLefitManager : MonoBehaviour
{
    #region public variable
    public TMP_Text txtHealthpercent;
    public TMP_Text txtScore;
    
    #endregion
    #region private variable
    #endregion
    #region public Method
    public void SetScoreText(int score)
    {
        txtScore.text = score.ToString();
    }
    #endregion
    #region private Method
    private void Start()
    {
        txtHealthpercent.text = Random.Range(0, 100).ToString();
        //txtScore.text = Random.Range(100, 3000).ToString();
    }
    private void Update()
    {
        Debug.Log("test");
        
    }
    #endregion

}
