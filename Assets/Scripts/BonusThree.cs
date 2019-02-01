using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusThree : MonoBehaviour
{//+20
    int bonusMoney = 20;
    void OnCollisionEnter2D(Collision2D other)
    {
        Bonus.money += bonusMoney;
        Debug.Log("BonusMoney = " + Bonus.money);
        Destroy(gameObject);
    }
    void Update()
    {
        GameObject player = GameObject.FindGameObjectsWithTag("Player")[0];

        if (transform.position.y - player.transform.position.y < -15f)
        {
            Destroy(gameObject);
        }
    }
}
