using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    // Start is called before the first frame update

    public enum Weapon
    {
        ORB,
        LASER,
        SPREAD
    }

    public Weapon weapon = Weapon.ORB;

    public float fireRate = 1;
    public int AmountOfShots = 1;
    public GameObject Orb;

    void Start()
    {
        Invoke("Shoot", fireRate);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void Shoot()
    {
        Instantiate(Orb, transform.position, Quaternion.identity);
        Invoke("Shoot", fireRate);
    }
}
