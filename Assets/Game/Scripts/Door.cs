using System;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private GameObject doorModel;
    
    private bool isOpen = false;

    public void Open()
    {
        if (isOpen)
            return;
        
       
        doorModel.SetActive(false);
        isOpen = true;
    }
    
    public void Close()
    {
        if (!isOpen)
            return;
        
        doorModel.SetActive(true);
        isOpen = false;
    }
}
