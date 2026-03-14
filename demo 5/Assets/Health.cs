public System.Action onDead;
public System.Action onHealthChanged;
public int healthPoint;

private static void Start()
{
    healthPoint = defaultHealthPoint;
    onHealthChanged?.Invoke();
}

public void TakeDamage(int damage)
{
    if (healthPoint <= 0) return;

    healthPoint -= damage;
    onHealthChanged?.Invoke();

    if (healthPoint <= 0) Die();
}