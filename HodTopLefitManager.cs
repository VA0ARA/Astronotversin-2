using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HodTopLefitManager : MonoBehaviour
{
    #region public variable
    public TMP_Text txtHealthpercent;
    public TMP_Text txtScore;
    public int dangerhealth;
    public Sprite BuleSprite;
    public Sprite Redsprite;
    public Image MainHDI;
    public int Health;
    private int vaset;


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
        vaset = Random.Range(0, 100);
        txtHealthpercent.text = vaset.ToString();
        //txtScore.text = Random.Range(100, 3000).ToString();
        Health = vaset;

    }

   private void Update()
    {
            if (Health < dangerhealth)
    {
        MainHDI.sprite = Redsprite;
    }
    else { MainHDI.sprite = BuleSprite; }

}
    #endregion

}

