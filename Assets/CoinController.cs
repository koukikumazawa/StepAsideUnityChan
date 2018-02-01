using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour {
    
    void Start()
    {
        //  回転を開始する角度
        this.transform.Rotate(0, Random.Range(0, 360), 0);
    }

    void Update()
    {
        //  回転させる
        this.transform.Rotate(0, 3, 0);
    }
}
