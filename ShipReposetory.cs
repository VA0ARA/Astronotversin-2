using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum shipsEnum
{
    Green1,
    Green2,
    Green3,
    Red1,
    Red2,
    Red3,
    Blue1,
    Blue2,
    Blue3
}
[System.Serializable]
public struct ShipStruct
{
    public shipsEnum key;
    public GameObject ship;
}

public class ShipReposetory : MonoBehaviour
{
    #region public variable
    
    public ShipStruct[] ships;
    #endregion
    #region private variable
    #endregion
    #region const variable
    private const string currentShiprepo = "currentShiprepo";
    private const string shipsrepo = "shipsrepo";
    #endregion
    #region public Method
    public GameObject GetCurrentShip(){

        int index= PlayerPrefs.GetInt(currentShiprepo);
        return ships[index].ship;
    }
    public void SetCurrentShip()
    {

    }
    public void ActiveNewShip()
    {

    }


    #endregion
    #region private Method
    private void Awake()
    {
        int rnd = Random.Range(0, 9);
        PlayerPrefs.SetInt(currentShiprepo, rnd);
    }
    #endregion

}
