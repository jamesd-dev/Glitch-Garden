using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Range(0f, 5f)]
    float speed = 0f;

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    public void SetMovementSpeed(float speed)
    {
        this.speed = speed;
    }
}
