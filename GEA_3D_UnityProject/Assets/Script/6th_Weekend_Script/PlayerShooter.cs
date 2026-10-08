using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletSpeed = 20f;
    public float fireCooldown = 0.2f;

    float lastFireTime = -999f;

    public void OnAttack(InputValue value)
    {
        if (Time.timeScale == 0f) return;
        if (Time.time < lastFireTime + fireCooldown) return;
        lastFireTime = Time.time;

        Quaternion spawnRotation = firePoint.rotation * Quaternion.Euler(90f, 0f, 0f);

        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, spawnRotation);
        
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.linearVelocity = firePoint.forward * bulletSpeed;
    }
}

