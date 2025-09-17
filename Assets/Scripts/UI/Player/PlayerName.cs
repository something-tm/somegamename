using System.Runtime.InteropServices.WindowsRuntime;
using TMPro;
using UnityEngine;

public class PlayerName : MonoBehaviour
{
    public Player player;
    private FloatingText floatingText;

    void Awake()
    {
        player = GetComponent<Player>();
        floatingText = GetComponentInChildren<FloatingText>();
        floatingText.SetText(player.entityName);
    }

    void Update()
    {
        if (player != null && player.Stats != null && floatingText != null) return;
        floatingText.SetText($"{player.entityName} ({player.Stats.currentHealth}/{player.Stats.maxHealth})");
    }
}
