using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class HubbulletManager : MonoBehaviour
{
    #region public variable
    public int dangerbulletCount;
    public Sprite BuleSprite;
    public Sprite Redsprite;
    public Image MainHDI;
    #endregion
    #region private variable
    public  TMP_Text txtBullet;
    #endregion
    #region private Method
    private void Start()
    {
       // txtBullet = GameObject.FindGameObjectWithTag("txtBullet").GetComponent<TMP_Text>();
        //txtBullet.text = Random.Range(20, 50)+"";
    }
    #endregion
    #region public Method
    public void Setbullet(int bullet)
    {
        txtBullet.text = bullet.ToString();
        if (bullet >= dangerbulletCount)
        {
            MainHDI.sprite = BuleSprite;
        }
        else { MainHDI.sprite = Redsprite; }
    }

    #endregion

}
