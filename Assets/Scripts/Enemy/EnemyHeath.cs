using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHeath : MonoBehaviour
{
    public GameObject ExplodeEffect;
    public EnemySribtableObject enemyData;
    public HealthBar healthBar;
    private int maxHealth;
    private int currentHealth;
    public PlayerBullet bullet;

    private void Start()
    {
        maxHealth = enemyData.enemyHealth;
        maxHealth = currentHealth;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(bullet)
        {
            TakeDamage(20);
        }
        
    }

    private void Update()
    {
        TankExplode();
    }

    private void TakeDamage(int damage)
    {
        currentHealth -= damage;
    }

    private void TankExplode()
    {
        if (currentHealth <= 0)
        {
            GameObject tankExplodeEffect = Instantiate(ExplodeEffect, transform.position, Quaternion.identity);
            Destroy(tankExplodeEffect, 3f);
            Destroy(gameObject);
        }
    }
}
