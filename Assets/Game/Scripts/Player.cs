using UnityEngine;
using UnityEngine.InputSystem;

namespace Game.Scripts
{
    [RequireComponent(typeof(PlayerInput))]
    [RequireComponent(typeof(PlayerMovement))]
    [RequireComponent(typeof(PlayerInteraction))]
    public class Player : MonoBehaviour
    {
        private PlayerMovement movement;
        private PlayerInteraction interaction;

        private void Awake()
        {
            movement = GetComponent<PlayerMovement>();
            interaction = GetComponent<PlayerInteraction>();
        }

        private void OnMove(InputValue value)
        {
            var input = value.Get<Vector2>();
            movement.Move(input);
        }

        private void OnInteract(InputValue value)
        {
            interaction.Interact();
        }
    }
}