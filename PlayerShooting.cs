using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab; // prefab пули из Project
    public Transform firePoint;     // объект FirePoint на сцене
    public float fireRate = 0.5f;   // время между выстрелами

    private float nextFireTime = 0f;

    void Update()
    {
        // срабатывает только один раз при нажатии ЛКМ
        if (Input.GetButtonDown("Fire1") && Time.time >= nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + fireRate;
        }
    }

    void Shoot()
    {
        if (bulletPrefab == null || firePoint == null) return;

        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        if (rb == null) rb = bullet.AddComponent<Rigidbody>();

        rb.useGravity = false;
        rb.collisionDetectionMode = CollisionDetectionMode.Continuous;
        rb.linearVelocity = firePoint.forward * 50f;

        Destroy(bullet, 3f);
    }
}
