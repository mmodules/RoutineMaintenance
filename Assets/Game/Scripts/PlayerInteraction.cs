using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] private Vector3 offset = Vector3.up;
    
    public void Interact()
    {
        var origin = transform.position + offset;
        if (!Physics.Raycast(origin, transform.forward, out var hitInfo, 3f))
            return;

        if (hitInfo.collider.TryGetComponent(out Door door))
        {
            door.Open();
        }
        
        if (hitInfo.collider.TryGetComponent(out ComputerSystem computerSystem))
        {
            computerSystem.Interact();
        }
    }
}
