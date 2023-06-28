using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public enum ShootPattern{
        STRAIGHT,
        CIRCLE,
        SPIRAL
    }

    float fireRate = 1;
    int AmountOfShots = 1;
    float Damage;
    public GameObject Bullet;
    public enum MovementPattern
    {
        Horizontal
    }

    public ShootPattern pattern = ShootPattern.STRAIGHT;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
