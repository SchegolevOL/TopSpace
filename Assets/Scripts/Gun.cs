using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{[SerializeField] Transform[] guns;
    [SerializeField] Bullet bulletPrefab;
    [SerializeField, Range(0.1f, 20f)] float reloadTime;

    int currentGunIndex;
    float timer;
    bool canShoot;

    private void Start()
    {
        currentGunIndex = 0;
        timer = 0;
        canShoot = true;
    }

    private void Update()
    {
        if (!canShoot) ReloadTimeControl();

        if (Input.GetButton("Fire1") && canShoot)
        {
            Bullet newBullet = Instantiate(bulletPrefab, guns[currentGunIndex].position, guns[currentGunIndex].rotation);
            canShoot = false;
            timer = reloadTime;
            currentGunIndex++;
            if (currentGunIndex == guns.Length) currentGunIndex = 0;
        }
    }

    private void ReloadTimeControl()
    {
        timer -= Time.deltaTime;
        if (timer <= 0) canShoot = true;
    }

}
