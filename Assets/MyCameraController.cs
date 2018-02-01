using UnityEngine;
using System.Collections;

public class MyCameraController : MonoBehaviour
{
    //  ユニティちゃんのオブジェクト
    private GameObject unitychan;
    //  ユニティちゃんとカメラの距離
    private float difference;

    void Start()
    {
        //  ユニティちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");
        //  ユニティちゃんとカメラの位置の差を求める
        this.difference = unitychan.transform.position.z - this.transform.position.z;

    }

    void Update()
    {
        //  ユニティちゃんの位置に合わせてカメラの位置を移動
        this.transform.position = new Vector3(0, this.transform.position.y, this.unitychan.transform.position.z - difference);
    }
}