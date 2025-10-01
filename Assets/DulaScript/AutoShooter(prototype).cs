using UnityEngine;

public class AutoShooter : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float fireRate = 1f;
    private float timer;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= fireRate)
        {
            Fire();
            timer = 0f;
        }
    }

    void Fire()
    {
        Vector2 dir = GetNearestEnemyDirection();
        if (dir == Vector2.zero) dir = Vector2.right; 
        var proj = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        proj.GetComponent<Rigidbody2D>().linearVelocity = dir.normalized * 10f;
    }

    Vector2 GetNearestEnemyDirection()
    {
        return Vector2.right; 
    }
}