﻿using UnityEngine;

public class EnemyHeath : MonoBehaviour
{
    public GameObject ExplodeEffect;
    public EnemySribtableObject enemyData;
    public HealthBar healthBar;
    private int maxHealth;
    private int currentHealth;

    private void Start()
    {
        maxHealth = enemyData.enemyHealth;
        currentHealth = maxHealth;
        healthBar.SetMaxhealth(maxHealth);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Playerbullet")
        {
            TakeDamage(10);
        }
        
    }

    private void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        if (currentHealth <= 0)
        {
            TankExplode();
        }
    }

    private void TankExplode()
    {
        GameObject tankExplodeEffect = Instantiate(ExplodeEffect, transform.position, Quaternion.identity);
        Destroy(tankExplodeEffect, 3f);
        Destroy(gameObject);
    }
}
