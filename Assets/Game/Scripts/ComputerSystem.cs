using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class ComputerSystem : MonoBehaviour
{
    [SerializeField] private GameObject doorModel;
    
    public void Interact()
    {
        doorModel.SetActive(false);
    }
}
