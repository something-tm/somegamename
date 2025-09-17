using UnityEngine;

[CreateAssetMenu(menuName = "Game/Stats")]
public class StatsData : ScriptableObject
{
    public int maxHealth = 100;
    public int attackPower = 3;
    public float moveSpeed = 5f;
    public int stamina = 100;
    public int manaEnergy = 5;
}