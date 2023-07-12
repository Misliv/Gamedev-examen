using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    // Start is called before the first frame update

    public int MaxHP = 1;
    public int CurrentHP = 1;

    void Start()
    {
        CurrentHP = MaxHP;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateHealth(int HealthChange)
    {
        CurrentHP += HealthChange;

        if (CurrentHP <= 0)
        {
            Death();
        }
    }

    void Death()
    {
        if (GetComponent<Enemy>() != null)
        {
            Destroy(gameObject);
        }
    }
}
