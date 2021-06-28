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
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""b9c88a25-b978-4497-aff4-acca53260aec"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""49d8e9fd-f9ca-44ab-b6ea-3c969ebb4d9a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
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
                    ""action"": ""Movement"",
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
                    ""action"": ""Movement"",
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
                    ""action"": ""Movement"",
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
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""BasicControlsP2"",
            ""id"": ""1cc36baa-17ab-440a-9f2f-28104435aa50"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""d7910e9b-7e3b-4f99-b732-dcb0606115d7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""045ee7ed-d5c0-47fc-acd4-1d39f7934861"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // BasicControlsP1
        m_BasicControlsP1 = asset.FindActionMap("BasicControlsP1", throwIfNotFound: true);
        m_BasicControlsP1_Movement = m_BasicControlsP1.FindAction("Movement", throwIfNotFound: true);
        // BasicControlsP2
        m_BasicControlsP2 = asset.FindActionMap("BasicControlsP2", throwIfNotFound: true);
        m_BasicControlsP2_Newaction = m_BasicControlsP2.FindAction("New action", throwIfNotFound: true);
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
    private readonly InputAction m_BasicControlsP1_Movement;
    public struct BasicControlsP1Actions
    {
        private @DefaultControls m_Wrapper;
        public BasicControlsP1Actions(@DefaultControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_BasicControlsP1_Movement;
        public InputActionMap Get() { return m_Wrapper.m_BasicControlsP1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BasicControlsP1Actions set) { return set.Get(); }
        public void SetCallbacks(IBasicControlsP1Actions instance)
        {
            if (m_Wrapper.m_BasicControlsP1ActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_BasicControlsP1ActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_BasicControlsP1ActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_BasicControlsP1ActionsCallbackInterface.OnMovement;
            }
            m_Wrapper.m_BasicControlsP1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
            }
        }
    }
    public BasicControlsP1Actions @BasicControlsP1 => new BasicControlsP1Actions(this);

    // BasicControlsP2
    private readonly InputActionMap m_BasicControlsP2;
    private IBasicControlsP2Actions m_BasicControlsP2ActionsCallbackInterface;
    private readonly InputAction m_BasicControlsP2_Newaction;
    public struct BasicControlsP2Actions
    {
        private @DefaultControls m_Wrapper;
        public BasicControlsP2Actions(@DefaultControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_BasicControlsP2_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_BasicControlsP2; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BasicControlsP2Actions set) { return set.Get(); }
        public void SetCallbacks(IBasicControlsP2Actions instance)
        {
            if (m_Wrapper.m_BasicControlsP2ActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_BasicControlsP2ActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_BasicControlsP2ActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_BasicControlsP2ActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_BasicControlsP2ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public BasicControlsP2Actions @BasicControlsP2 => new BasicControlsP2Actions(this);
    public interface IBasicControlsP1Actions
    {
        void OnMovement(InputAction.CallbackContext context);
    }
    public interface IBasicControlsP2Actions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
