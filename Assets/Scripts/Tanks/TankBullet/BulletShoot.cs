using UnityEngine;

public class BulletShoot : MonoBehaviour
{
    [SerializeField] private BulletPool bulletPool;
    [SerializeField] private GameObject firePoint;

    private void Shoot()
    {
        GameObject bullet = bulletPool.GetPooledObject();

        if(bullet != null)
        {
            bullet.transform.position = firePoint.transform.position;
            bullet.transform.rotation = firePoint.transform.rotation;
            bullet.SetActive(true);
        }
        
    }
 
}
