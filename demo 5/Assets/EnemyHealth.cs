using System;

public class EnemyHealth : Health
{
    public static int LivingEnemyCount;

    private void Awake()
    {
        LivingEnemyCount++;
    }

    protected override void Die()
    {
        LivingEnemyCount--;
        base.Die();
    }

    internal void TakeDamage(int damage)
    {
        throw new NotImplementedException();
    }
}