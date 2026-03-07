using System;
using UnityEngine;

public class PlayerHealth : Health
{
    protected override void Die()
    {
        base.Die();
        Debug.Log("Player died");
    }

    internal void TakeDamage(int damage)
    {
        throw new NotImplementedException();
    }
}
