using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletSpawner : MonoBehaviour
{
    enum SpawnerType { Straight, Spin }

    [Header ("Bullet Attributes")]
    public gameObject Bullet;
    public float bulletLife = 1f;
    public float speed = 1f;

    [Header ("Spawner Attributes")]
    [SerializeField] private SpawnerType spawnerType;
    [SerializeField] private float firingRate = 1f;
}
