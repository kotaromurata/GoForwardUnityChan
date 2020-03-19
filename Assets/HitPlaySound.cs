using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPlaySound: MonoBehaviour
{
    //当たった時の処理
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "CubeTag")
        {
            GetComponent<AudioSource>().Play();
        }
        if (collision.gameObject.tag == "GroundTag")
        {
            GetComponent<AudioSource>().Play();
        }
    }
}