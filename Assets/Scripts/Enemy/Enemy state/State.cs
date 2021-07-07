using System.Collections;
using UnityEngine;

public abstract class State : MonoBehaviour
{
    public virtual IEnumerator EnemyPatrol()
    {

        yield break;
    }

    public virtual IEnumerator ChasePlayer()
    {

        yield break;
    }

    public virtual IEnumerator AttackPlayer()
    {

        yield break;
    }
}

