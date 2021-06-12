using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    [SerializeField]private float bulletforce = 20f;

    private void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody rb = bulletPrefab.GetComponent<Rigidbody>();
        rb.AddForce(firePoint.transform.forward * bulletforce, ForceMode.Impulse);
    }

   
}
