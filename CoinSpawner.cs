using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    #region public variable
    public Vector2 coinToSpawner;
    public GameObject coinprefabs;
    #endregion
    #region private variable
    #endregion
    #region public method 
    #endregion
    #region private variable
    private void Start()
    {
        int countOfCoinTospawn=(int)Random.Range(coinToSpawner.x,coinToSpawner.y);
        for (int i = 0; i < countOfCoinTospawn; i++)
        {
            Instantiate(coinprefabs, transform.position, Quaternion.identity);
        }
        Destroy(gameObject);
    }
    #endregion

}
