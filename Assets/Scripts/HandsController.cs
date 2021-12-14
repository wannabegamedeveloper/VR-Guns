using UnityEngine;
using UnityEngine.InputSystem;

public class HandsController : MonoBehaviour
{
    [SerializeField] private HandType type;
    [SerializeField] private Animator handAnimators;
    
    private PlayerInput playerInput;
    private int animatorHash;
    
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
        if (type == HandType.Left)
            playerInput.Hands.LeftHand.performed += Hand;
        else if (type == HandType.Right)
            playerInput.Hands.RightHand.performed += Hand;
            
        animatorHash = Animator.StringToHash("Grab");
    }

    private void Hand(InputAction.CallbackContext callbackContext)
    {
        handAnimators.SetFloat(animatorHash, callbackContext.ReadValue<float>());
    }
    
    private void OnDisable()
    {
        playerInput.Disable();
    }

    private enum HandType
    {
        Left,
        Right
    }
}
