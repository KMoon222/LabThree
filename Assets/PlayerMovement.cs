using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private InputSystem_Actions inputActions;

    void Awake()
    {
        inputActions = new InputSystem_Actions();
    }

    private void OnEnable()
    {
        inputActions.Player.Enable();
    }

    private void OnDisable()
    {
        inputActions.Player.Disable();
    }

    void Update()
    {
        // move player with input, clamp to camera bounds
        Vector2 moveVector = inputActions.Player.Move.ReadValue<Vector2>();
        transform.Translate(new Vector2(moveVector.x, 0) * Time.deltaTime * 5f);
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -9.4f, 9.4f), 0);
    }
}
