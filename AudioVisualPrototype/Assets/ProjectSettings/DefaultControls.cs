// GENERATED AUTOMATICALLY FROM 'Assets/ProjectSettings/DefaultControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @DefaultControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @DefaultControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""DefaultControls"",
    ""maps"": [
        {
            ""name"": ""BasicControlsP1"",
            ""id"": ""56055e31-bd55-4059-9800-89528ad9f72a"",
            ""actions"": [
                {
                    ""name"": ""MovementP1"",
                    ""type"": ""Value"",
                    ""id"": ""b9c88a25-b978-4497-aff4-acca53260aec"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Camera"",
                    ""type"": ""Value"",
                    ""id"": ""af7b5889-7d72-4ac1-8d49-3acd1887a92c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MovementP2"",
                    ""type"": ""Value"",
                    ""id"": ""0d2fdaf7-ea42-431f-b797-0a6af2d6cb66"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""11c6c483-8b44-42b3-94c4-3c8b8f79e6c4"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bc7f6834-3184-402e-9ffd-d334795715a0"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""49d8e9fd-f9ca-44ab-b6ea-3c969ebb4d9a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementP2"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b14b8b24-6d94-440d-99b6-a1c944566328"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementP2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""44df92e3-c942-41fd-86f0-3769d43b003f"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementP2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""373413ad-fd8c-446e-bce9-2ffd054b6cd3"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementP2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""4d2f681e-0f1a-456c-9cc5-39d16e084be0"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementP2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""f7724035-516a-48ba-8e64-c355f4a329ad"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementP1"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""76a6c8bb-b4c4-45f7-a949-fe302f835a96"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementP1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""33027fbb-8a77-4c55-b47a-9290c0722798"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementP1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""11ed55ec-48e2-425e-a65b-dae0822578bb"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementP1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""901b32df-c4e3-4b27-9af3-912797c076c0"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementP1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // BasicControlsP1
        m_BasicControlsP1 = asset.FindActionMap("BasicControlsP1", throwIfNotFound: true);
        m_BasicControlsP1_MovementP1 = m_BasicControlsP1.FindAction("MovementP1", throwIfNotFound: true);
        m_BasicControlsP1_Camera = m_BasicControlsP1.FindAction("Camera", throwIfNotFound: true);
        m_BasicControlsP1_MovementP2 = m_BasicControlsP1.FindAction("MovementP2", throwIfNotFound: true);
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

    // BasicControlsP1
    private readonly InputActionMap m_BasicControlsP1;
    private IBasicControlsP1Actions m_BasicControlsP1ActionsCallbackInterface;
    private readonly InputAction m_BasicControlsP1_MovementP1;
    private readonly InputAction m_BasicControlsP1_Camera;
    private readonly InputAction m_BasicControlsP1_MovementP2;
    public struct BasicControlsP1Actions
    {
        private @DefaultControls m_Wrapper;
        public BasicControlsP1Actions(@DefaultControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MovementP1 => m_Wrapper.m_BasicControlsP1_MovementP1;
        public InputAction @Camera => m_Wrapper.m_BasicControlsP1_Camera;
        public InputAction @MovementP2 => m_Wrapper.m_BasicControlsP1_MovementP2;
        public InputActionMap Get() { return m_Wrapper.m_BasicControlsP1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BasicControlsP1Actions set) { return set.Get(); }
        public void SetCallbacks(IBasicControlsP1Actions instance)
        {
            if (m_Wrapper.m_BasicControlsP1ActionsCallbackInterface != null)
            {
                @MovementP1.started -= m_Wrapper.m_BasicControlsP1ActionsCallbackInterface.OnMovementP1;
                @MovementP1.performed -= m_Wrapper.m_BasicControlsP1ActionsCallbackInterface.OnMovementP1;
                @MovementP1.canceled -= m_Wrapper.m_BasicControlsP1ActionsCallbackInterface.OnMovementP1;
                @Camera.started -= m_Wrapper.m_BasicControlsP1ActionsCallbackInterface.OnCamera;
                @Camera.performed -= m_Wrapper.m_BasicControlsP1ActionsCallbackInterface.OnCamera;
                @Camera.canceled -= m_Wrapper.m_BasicControlsP1ActionsCallbackInterface.OnCamera;
                @MovementP2.started -= m_Wrapper.m_BasicControlsP1ActionsCallbackInterface.OnMovementP2;
                @MovementP2.performed -= m_Wrapper.m_BasicControlsP1ActionsCallbackInterface.OnMovementP2;
                @MovementP2.canceled -= m_Wrapper.m_BasicControlsP1ActionsCallbackInterface.OnMovementP2;
            }
            m_Wrapper.m_BasicControlsP1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MovementP1.started += instance.OnMovementP1;
                @MovementP1.performed += instance.OnMovementP1;
                @MovementP1.canceled += instance.OnMovementP1;
                @Camera.started += instance.OnCamera;
                @Camera.performed += instance.OnCamera;
                @Camera.canceled += instance.OnCamera;
                @MovementP2.started += instance.OnMovementP2;
                @MovementP2.performed += instance.OnMovementP2;
                @MovementP2.canceled += instance.OnMovementP2;
            }
        }
    }
    public BasicControlsP1Actions @BasicControlsP1 => new BasicControlsP1Actions(this);
    public interface IBasicControlsP1Actions
    {
        void OnMovementP1(InputAction.CallbackContext context);
        void OnCamera(InputAction.CallbackContext context);
        void OnMovementP2(InputAction.CallbackContext context);
    }
}
