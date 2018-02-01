﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour {
    //  carのPrefabを入れる
    public GameObject carPrefab;
    //  coinのPrefabを入れる
    public GameObject coinPrefab;
    //  cornのPrefabを入れる
    public GameObject conePrefab;
    //  スタート地点
    private int startPos = -160;
    //  ゴール地点
    private int goalPos = 120;
    //  アイテムを出すx方向の範囲
    private float posRange = 3.4f;


    void Start()
    {
        //  一定の距離ごとでアイテム生成
        for (int i = startPos; i < goalPos; i += 15)
        {
            //  出すアイテムをランダムに設定
            int num = Random.Range(0, 10);
            if (num <= 1)
            {
                //  コーンをx軸方向に一直線に生成
                for (float j = -1; j <= 1; j += 0.4f)
                {
                    GameObject cone = Instantiate(conePrefab) as GameObject;
                    cone.transform.position = new Vector3(4 * j, cone.transform.position.y, i);
                }
            }
            else
            {

                //  レーンごとにアイテムを生成
                for (int j = -1; j < 2; j++)
                {
                    //  アイテムの種類を決める
                    int item = Random.Range(1, 11);
                    //  アイテムを置くZ座標のオフセットをランダムに設定
                    int offsetZ = Random.Range(-5, 6);
                    //  60%コイン:30%車:10%なし
                    if (1 <= item && item <= 6)
                    {
                        //  コインを生成
                        GameObject coin = Instantiate(coinPrefab) as GameObject;
                        coin.transform.position = new Vector3(posRange * j, coin.transform.position.y, i + offsetZ);
                    }
                    else if (7 <= item && item <= 9)
                    {
                        //  車を生成
                        GameObject car = Instantiate(carPrefab) as GameObject;
                        car.transform.position = new Vector3(posRange * j, car.transform.position.y, i + offsetZ);
                    }
                }
            }
        }
    }


    void Update () {
		
	}
}
