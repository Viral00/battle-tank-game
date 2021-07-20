using System.Collections;
using UnityEngine;

public class Attack : State
{
    public GameObject enemyBullet;
    public Transform Shootpoint;
    public override IEnumerator AttackPlayer()
    {
        GameObject Shoot = Instantiate(enemyBullet, Shootpoint.position, Shootpoint.rotation);
        return base.AttackPlayer();
    }
}
