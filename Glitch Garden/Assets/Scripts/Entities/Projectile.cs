using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    [SerializeField] float damage = 50f;
    [SerializeField] GameObject hitEffect;

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy")
        {
            CreateHitEffect();
            Health enemyHealth = collision.GetComponent<Health>();
            enemyHealth.DealDamage(damage);
            Destroy(gameObject);
        }
    }

    private void CreateHitEffect()
    {
        Instantiate(hitEffect, transform.position, Quaternion.identity);
    }
}
