using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectile;
    [SerializeField] Transform projectileSpawnPos;

    public void Fire()
    {
        Instantiate(projectile, projectileSpawnPos.position, Quaternion.identity);
    }
}
