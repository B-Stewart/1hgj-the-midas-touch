using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootObject : MonoBehaviour
{

    public GameObject PrefabToShoot;
    public float timeBetweenShots = 1.0f;
    public float delayBeforeShooting = 2.0f;
    public bool randomOffset = false;
    public Vector3 direction;

    private float spawnDistance = 1.0f;
    private float randomValue = 0.0f;


    // Use this for initialization
    void Start()
    {
        if (randomOffset)
            randomValue = (Random.value) * 0.5f;
        InvokeRepeating("Shoot", delayBeforeShooting, timeBetweenShots + randomValue);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Shoot()
    {
        GameObject.Instantiate(PrefabToShoot, transform.position + spawnDistance * direction, transform.rotation);
    }
}
