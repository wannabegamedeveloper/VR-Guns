using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandsController : MonoBehaviour
{
    private PlayerInput playerInput;

    private void Awake()
    {
        playerInput = new PlayerInput();
    }

    private void OnEnable()
    {
        playerInput.Enable();
    }

    private void Start()
    {
        playerInput.Hands.Grab.performed += Hand;
    }

    private void Hand(InputAction.CallbackContext callbackContext)
    {
        print(callbackContext.ReadValue<float>());
    }
    
    private void OnDisable()
    {
        playerInput.Disable();
    }
}
