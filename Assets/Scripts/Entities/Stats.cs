using UnityEngine;

public class Stats
{

    private StatsData baseStats;
    public int currentHealth { get; private set; }
    public int maxHealth => baseStats.maxHealth;
    public int attackPower => baseStats.attackPower;
    public float moveSpeed => baseStats.moveSpeed;

    public Stats(StatsData data)
    {
        baseStats = data;
        currentHealth = data.maxHealth;
    }

    public void TakeDamage(int amount)
    {
        currentHealth = Mathf.Max(currentHealth - amount, 0);
    }

    public void Heal(int amount)
    {
        currentHealth = Mathf.Min(currentHealth + amount, maxHealth);
    }
}