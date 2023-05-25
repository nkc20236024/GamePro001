using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class arrowController : MonoBehaviour
{
    GameObject player;
    void Start()
    {
        this.player = GameObject.Find("player");
    }


    void Update()
    {
        //画面外に出たらオブジェクトを破壊する
        if (transform.position.y < -5.0f)
        {
            Debug.Log(gameObject);
        }
        //当たり判定
        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 1.0f;

        if (d < r1 + r2)
        {
            //  衝突した場合は矢を消す
            Debug.Log(gameObject);
        }
    }
}
