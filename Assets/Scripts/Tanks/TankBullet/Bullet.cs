using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float bulletforce = 20f;
    [SerializeField] private Transform firepoint;

    private void Update()
    {
        //rb.velocity = Vector3.forward * bulletforce;
        //rb.AddForce(firePoint.transform.forward * bulletforce, ForceMode.Impulse);
        rb.AddForce(transform.forward * bulletforce, ForceMode.Impulse);
        rb.AddForce(transform.up * 8f, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
    {
        gameObject.SetActive(false);
    }
}
