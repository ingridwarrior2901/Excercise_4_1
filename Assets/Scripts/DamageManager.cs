using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageManager : MonoBehaviour
{
    private const int damage = 10;

    private void OnTriggerEnter(Collider other)
    {
        IDamageable damagableObject = other.gameObject.GetComponent<IDamageable>();
        if (damagableObject != null)
        {
            damagableObject.OnDamage(damage);
        }
    }
}
