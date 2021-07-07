using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPool : MonoBehaviour
{
    [SerializeField] private GameObject BulletPrefab;
    [SerializeField] private Transform firePoint;
    private List<GameObject> poolBullet = new List<GameObject>();
    private int amountToPool = 10;

    private void Start()
    {
        for (int i =0; i < amountToPool; i++)
        {
            GameObject bullet = Instantiate(BulletPrefab, firePoint.position, firePoint.rotation);
            bullet.SetActive(false);
            poolBullet.Add(bullet);
        }
        
    }

    public GameObject GetPooledObject()
    {
        for(int i =0 ; i < poolBullet.Count ; i++)
        {
            if (!poolBullet[i].activeInHierarchy)
            {
                return poolBullet[i];
            }
        }

        return null;
    }
}
