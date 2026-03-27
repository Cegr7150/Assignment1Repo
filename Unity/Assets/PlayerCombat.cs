using UnityEngine;
using UnityEngine.InputSystem; // This is required!

public class PlayerCombat : MonoBehaviour
{
    // 1. Create a variable for your generated class
    private GameControls controls;

    void Awake()
    {
        // 2. Initialize it
        controls = new GameControls();
    }

    void OnEnable()
    {
        // 3. Enable the controls
        controls.Enable();
    }

    void OnDisable()
    {
        // 4. Disable when not in use
        controls.Disable();
    }

    void Update()
    {
        // 5. Check for the attack action
        if (controls.Player.Attack.WasPressedThisFrame())
        {
            Debug.Log("Attack!!");
        }
    }
}
