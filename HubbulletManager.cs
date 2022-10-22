using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HubbulletManager : MonoBehaviour
{
    #region public variable
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
    }

    #endregion

}
