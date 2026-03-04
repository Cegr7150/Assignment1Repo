using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 5f;
    public float gravity = -9.81f;
    Vector3 velocity;

    void Update()
    {
        // 1. Get Input
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        // 2. Calculate Direction
        Vector3 move = transform.right * x + transform.forward * z;

        // 3. Move the Controller
        controller.Move(move * speed * Time.deltaTime);

        // 4. Apply Gravity
        if (controller.isGrounded && velocity.y < 0) velocity.y = -2f;
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}