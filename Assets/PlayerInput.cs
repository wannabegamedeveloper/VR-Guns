// GENERATED AUTOMATICALLY FROM 'Assets/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Gun"",
            ""id"": ""297d30be-7819-42a1-9c5b-8791e733862f"",
            ""actions"": [
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""50ecd55c-5d0e-47d4-ad57-2a191e3c9a79"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""826a178f-49da-41b7-924d-68c4143971bd"",
                    ""path"": ""<XRController>{RightHand}/triggerPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Hands"",
            ""id"": ""95a5f20e-b5d9-43bc-a6bb-cda43fa6e7fe"",
            ""actions"": [
                {
                    ""name"": ""Grab"",
                    ""type"": ""Value"",
                    ""id"": ""f069902a-4813-42b9-b68a-ff236fb2465c"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0a9a9cb5-e281-43ce-8046-556849812941"",
                    ""path"": ""<XRController>{RightHand}/grip"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gun
        m_Gun = asset.FindActionMap("Gun", throwIfNotFound: true);
        m_Gun_Shoot = m_Gun.FindAction("Shoot", throwIfNotFound: true);
        // Hands
        m_Hands = asset.FindActionMap("Hands", throwIfNotFound: true);
        m_Hands_Grab = m_Hands.FindAction("Grab", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Gun
    private readonly InputActionMap m_Gun;
    private IGunActions m_GunActionsCallbackInterface;
    private readonly InputAction m_Gun_Shoot;
    public struct GunActions
    {
        private @PlayerInput m_Wrapper;
        public GunActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Shoot => m_Wrapper.m_Gun_Shoot;
        public InputActionMap Get() { return m_Wrapper.m_Gun; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GunActions set) { return set.Get(); }
        public void SetCallbacks(IGunActions instance)
        {
            if (m_Wrapper.m_GunActionsCallbackInterface != null)
            {
                @Shoot.started -= m_Wrapper.m_GunActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_GunActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_GunActionsCallbackInterface.OnShoot;
            }
            m_Wrapper.m_GunActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
            }
        }
    }
    public GunActions @Gun => new GunActions(this);

    // Hands
    private readonly InputActionMap m_Hands;
    private IHandsActions m_HandsActionsCallbackInterface;
    private readonly InputAction m_Hands_Grab;
    public struct HandsActions
    {
        private @PlayerInput m_Wrapper;
        public HandsActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Grab => m_Wrapper.m_Hands_Grab;
        public InputActionMap Get() { return m_Wrapper.m_Hands; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(HandsActions set) { return set.Get(); }
        public void SetCallbacks(IHandsActions instance)
        {
            if (m_Wrapper.m_HandsActionsCallbackInterface != null)
            {
                @Grab.started -= m_Wrapper.m_HandsActionsCallbackInterface.OnGrab;
                @Grab.performed -= m_Wrapper.m_HandsActionsCallbackInterface.OnGrab;
                @Grab.canceled -= m_Wrapper.m_HandsActionsCallbackInterface.OnGrab;
            }
            m_Wrapper.m_HandsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Grab.started += instance.OnGrab;
                @Grab.performed += instance.OnGrab;
                @Grab.canceled += instance.OnGrab;
            }
        }
    }
    public HandsActions @Hands => new HandsActions(this);
    public interface IGunActions
    {
        void OnShoot(InputAction.CallbackContext context);
    }
    public interface IHandsActions
    {
        void OnGrab(InputAction.CallbackContext context);
    }
}
