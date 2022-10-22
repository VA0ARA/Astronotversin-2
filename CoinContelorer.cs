using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinContelorer : MonoBehaviour
{
    #region public variable
    public float Speed;


    #endregion
    #region private variable
    private Vector2 direction;
    #endregion
    #region public Method
    #endregion
    #region private Method
    private void Start()
    {
        direction = Vector2.up;
        direction.x = Random.Range(-4f, 4f);
        Invoke("GoDown", 0.4f);
        
    }
    private void Update()
    {
        transform.Translate(direction * Speed * Time.deltaTime);
        
    }
    private void GoDown()
    {
        direction.y *= -1;
        direction.x = 0;
    }
    #endregion

}
