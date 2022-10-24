using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joystick : MonoBehaviour
{
    #region public variable
    
    public GameObject joystickBotton;
    public GameObject fireBottom;
    #endregion
    #region private variable 
    private ShipConteroler ship;
    #endregion
    #region public Method
    public void Fire()
    {
        ship.FireButtom();
    }
    public void MooveRight()
    {
        ship.MoveRight();
    }
    public void MoveLeft()
    {
        ship.MoveLeft();

    }
    public void MoveUp()
    {
        ship.MoveUp();

    }
    public void MoveDown()
    {
        ship.MoveDown();

    }
    public void StopMove()
    {
        ship.StopMoving();
    }
    #endregion
    #region private Method
    private void LateUpdate()
    {
        if (ship == null)
        {
            joystickBotton.gameObject.SetActive(false);
            fireBottom.SetActive(false);
            ship = GameObject.FindObjectOfType<ShipConteroler>();
        }
        else{
            joystickBotton.gameObject.SetActive(true);
            fireBottom.SetActive(true);

        }
    }
    #endregion

}
