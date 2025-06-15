using UnityEngine;

public class EnemyShooter : MonoBehaviour
{
    public GameObject bulletPrefab;     // Assign your bullet prefab
    public Transform firePoint;         // Create a child transform at the muzzle
    public float shootInterval = 2f;    // Interval between shots
    public float bulletSpeed = 20f;     // Bullet travel speed

    private Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player")?.transform;// Find the player by tag
        InvokeRepeating(nameof(Shoot), 1f, shootInterval);// Start shooting after 1 second and repeat every shootInterval seconds
    }

    void Shoot()
    {
        if (player == null || bulletPrefab == null || firePoint == null) return;

        Vector3 direction = (player.position - firePoint.position).normalized;// Calculate the direction to the player
        Quaternion rotation = Quaternion.LookRotation(direction);// Create a rotation that looks in the direction of the player

        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, rotation);// Instantiate the bullet at the fire point with the calculated rotation
        Rigidbody rb = bullet.GetComponent<Rigidbody>();// Get the Rigidbody component of the bullet
        if (rb != null)
        {
            rb.linearVelocity = direction * bulletSpeed;// Set the bullet's velocity in the direction of the player
        }
    }
}
