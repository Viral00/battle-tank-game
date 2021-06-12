using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public GameObject shellExplotion;

    private void OnCollisionEnter(Collision collision)
    {
        GameObject effect = Instantiate(shellExplotion, transform.position, Quaternion.identity);
        Destroy(effect, 3f);
        Destroy(gameObject);
    }
}
