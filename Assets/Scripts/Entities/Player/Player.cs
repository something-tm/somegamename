// tells unity that this class can be saved, loaded, and show in the inspector
public class Player : Entity
{
    private PlayerController controller;

    public Stats Stats => stats;

    protected override void Awake()
    {
        base.Awake();
        entityName = "Player";
        controller = GetComponent<PlayerController>();

        stats ??= new Stats(baseStats);
    }
}