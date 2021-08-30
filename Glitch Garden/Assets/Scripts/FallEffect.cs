using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallEffect : MonoBehaviour
{
    [SerializeField] Transform feetPos;
    [SerializeField] GameObject impactEffectPrefab;

    public void FallImpact()
    {
        Instantiate(impactEffectPrefab, feetPos.position, Quaternion.identity, transform);
        Camera.main.GetComponent<CameraShake>().Shake();
    }
}
