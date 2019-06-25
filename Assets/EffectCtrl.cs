using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectCtrl : MonoBehaviour
{
    public static EffectCtrl instance;
    public Effect effect;

    void Awake()
    {
        if(instance == null)
        instance = this;
    }

    public void CreateExplosionEffect(Vector3 pos)
    {
        Instantiate(effect.explosionParticleEffect, pos, Quaternion.identity);
    }
}