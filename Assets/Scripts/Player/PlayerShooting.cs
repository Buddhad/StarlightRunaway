using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab;   
    public Transform firePoint;       
    public float bulletSpeed = 20f;  
    public float fireRate = 0.2f;    
    
    private float fireCooldown = 0f;

    void Update()
    {
        if (Input.GetButton("Fire1") && fireCooldown <= 0f)
        {
            Shoot();
            fireCooldown = fireRate;
        }

        if (fireCooldown > 0f)
        {
            fireCooldown -= Time.deltaTime;
        }
    }

    void Shoot()
    {
        if (bulletPrefab == null || firePoint == null)
        {
            Debug.LogError("BulletPrefab or FirePoint is not assigned.");
            return;
        }
    
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.velocity = firePoint.up * bulletSpeed;  // Peluru bergerak ke arah atas (sesuaikan jika arahnya berbeda)
    }
}


