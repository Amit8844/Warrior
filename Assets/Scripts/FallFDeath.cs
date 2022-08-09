using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallFDeath : MonoBehaviour
{

    private Stats stats;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out IDamageable damageable))
        {
            damageable.Damage(100f);
           
            return;
        }
    }
}
