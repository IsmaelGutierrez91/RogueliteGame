using UnityEngine;

public class Projectile : MonoBehaviour
{
    private float damage;
    private float range;
    private Vector3 direction;
    private Vector3 startPos;

    public void Init(float dmg, float rng, Vector3 dir)
    {
        damage = dmg;
        range = rng;
        direction = dir.normalized;
        startPos = transform.position;
    }

    private void Update()
    {
        transform.position += direction * 5f * Time.deltaTime; // velocidad fija

        if (Vector3.Distance(startPos, transform.position) >= range)
            Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}