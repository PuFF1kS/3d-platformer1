using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int coins;
    public GameObject fireballPrefab;
    public Transform attackPoint;
    public AudioSource audiosource;
    public AudioClip damageSound;
    private int health = 10;
    public void TakeDamage(int damage)
    {
        health -= damage;
        print("Здоровье игрока:" + health);
    }


    public void CollectCoins()
    {
        coins++;

        print("Собранные монетки: " + coins);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
    }
}