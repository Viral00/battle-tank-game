using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : State
{
    private TankMovement player;
    public override IEnumerator ChasePlayer()
    {
        Quaternion targetRotation = Quaternion.LookRotation(player.transform.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 1 * Time.deltaTime);
        transform.position += transform.forward * 1.7f * Time.deltaTime;
        
        return base.ChasePlayer();
    }
}
