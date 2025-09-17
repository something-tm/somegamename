using UnityEngine;
public class Entity : MonoBehaviour
{
    [Header("Entity Info")]
    public string entityName = "Entity";
    public StatsData baseStats;
    protected Stats stats;

    protected virtual void Awake()
    {
        stats = new Stats(baseStats);
    }

    public virtual void TakeDamage(int amount)
    {
        stats.TakeDamage(amount);
        if (stats.currentHealth <= 0)
        {
            Die();
        }
    }

    protected virtual void Die()
    {
        Destroy(gameObject);
    }

}