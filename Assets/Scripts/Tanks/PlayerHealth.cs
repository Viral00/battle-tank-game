using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public GameObject ExplodeEffect;
    public TankScriptableData TankData;
    public PlayerHealthBar healthBar;
    private int maxHealth;
    private int currentHealth;
    public Bullet bullet;

    private void Start()
    {
        maxHealth = TankData.tankHealth;
        currentHealth = maxHealth;
        healthBar.SetPlayerMaxhealth(maxHealth);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemybullet")
        {
            TakeDamage(10);
        }
    }

    private void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetPlayerHealth(currentHealth);
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
