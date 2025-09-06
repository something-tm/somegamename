using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 5f;

    // private so that no one can access it outside this class
    private Rigidbody2D rigidBody;
    private Vector2 movement;
    private InputSystem_Actions playerControls;

    // basically, this function starts before the Start()
    // READ https://docs.unity3d.com/6000.0/Documentation/ScriptReference/MonoBehaviour.html
    private void Awake()
    {
        playerControls = new InputSystem_Actions();
    }

    private void OnEnable() => playerControls.Enable();
    private void OnDisable() => playerControls.Disable();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // calls the component in the inspector bound to the Player entity
        rigidBody = GetComponent<Rigidbody2D>();

        // so it doesn't fall into the void
        rigidBody.gravityScale = 0f;

        // because 2d doesn't have a z dimension duh
        rigidBody.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        // reads the movement value of player in Vector2 or (x,y)
        movement = playerControls.Player.Move.ReadValue<Vector2>();

        // shows you the value of the player in the console when Player moves
        if (movement != Vector2.zero)
        {
            Debug.Log("Movement vector: " + movement);
        }
    }

    void FixedUpdate()
    {
        /*
         *  rigidBody.position is the current pos of player
         *  plus movement value
         *  multiplying it with movement speed
         *  Time.fixedDeltaTime is used for fixing the framerate bound movement
         */
        rigidBody.MovePosition(rigidBody.position + movement * movementSpeed * Time.fixedDeltaTime);
    }
}
