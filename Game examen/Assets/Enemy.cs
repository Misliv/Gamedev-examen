using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
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
    public float horizontalSpeed;
    public float verticalSpeed;
    public float rotationalSpeed;
    public bool movingRight;
    public float switchTime;

    public enum MovementPattern
    {
       Horizontal,
       Vertical,
       Zigzag,
       Circular
    }

    public ShootPattern shootpattern = ShootPattern.STRAIGHT;
    public MovementPattern movementpattern = MovementPattern.Horizontal;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Switch", switchTime);
    }
    void Switch()
    {
        movingRight = !movingRight;
        Invoke("Switch", switchTime * 2);
    }

    // Update is called once per frame
    void Update()
    {
        switch (movementpattern)
        {
            case MovementPattern.Horizontal:
                if (movingRight)
                {
                    transform.position += Vector3.right * horizontalSpeed * Time.deltaTime;
                }
                 
                else
                {
                    transform.position += Vector3.left * horizontalSpeed * Time.deltaTime;
                }
                break;

            case MovementPattern.Vertical:
                break;

            case MovementPattern.Zigzag:
                break;

            case MovementPattern.Circular:
                break;
        }
    }
}
