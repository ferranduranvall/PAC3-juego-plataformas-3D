using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionVehicle : MonoBehaviour
{

    public GameObject vehicleExplosion;
    public ParticleSystem explosion;

    public AudioSource audioExplosion;

    private void Awake()
    {
       explosion = GetComponentInChildren<ParticleSystem>();
    }

    public void Explosion()
    {
        explosion.Play();
        audioExplosion.Play();
        Destroy(gameObject, 1f);
    }
}
