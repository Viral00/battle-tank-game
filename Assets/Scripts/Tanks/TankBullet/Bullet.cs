using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float bulletforce = 20f;
    private AchiementController achievements;

    private void Start()
    {
        achievements = gameObject.GetComponent<AchiementController>();
    }

    private void Update()
    {
        rb.AddForce(transform.forward * bulletforce, ForceMode.Impulse);
        rb.AddForce(transform.up * 8f, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            achievements.IncreaseScore(10);
        }
        gameObject.SetActive(false);
    }
}
