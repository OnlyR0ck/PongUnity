// GENERATED AUTOMATICALLY FROM 'Assets/Input System/InputManager.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputManager : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputManager()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputManager"",
    ""maps"": [
        {
            ""name"": ""1STPlayer"",
            ""id"": ""0c579883-34c1-4be8-8fed-5db4ea23868a"",
            ""actions"": [
                {
                    ""name"": ""1STMove"",
                    ""type"": ""Value"",
                    ""id"": ""eb21f7cf-5065-4b28-ad38-228260c75946"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""f477e343-8d9f-48a2-b1cb-d4bd8423e831"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""1STMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""f439051b-c456-4218-9be0-94fe2b2198fd"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""1STMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""fc079d97-d1a6-4a4e-9c1c-18826856bc5a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""1STMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""2NDPlayer"",
            ""id"": ""d434091f-b225-434c-a39a-0ab660fc13ee"",
            ""actions"": [
                {
                    ""name"": ""2NDMove"",
                    ""type"": ""Value"",
                    ""id"": ""5fdd0504-1ab0-462f-b802-9af52b279c03"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""945833d9-62bb-42cc-abf3-55aef39a7b87"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""2NDMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""f010fce7-47c6-471f-a097-aa141867d71e"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""2NDMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""c936ee0f-479c-43d6-9a3a-0bfec949b723"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""2NDMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // 1STPlayer
        m__1STPlayer = asset.FindActionMap("1STPlayer", throwIfNotFound: true);
        m__1STPlayer__1STMove = m__1STPlayer.FindAction("1STMove", throwIfNotFound: true);
        // 2NDPlayer
        m__2NDPlayer = asset.FindActionMap("2NDPlayer", throwIfNotFound: true);
        m__2NDPlayer__2NDMove = m__2NDPlayer.FindAction("2NDMove", throwIfNotFound: true);
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

    // 1STPlayer
    private readonly InputActionMap m__1STPlayer;
    private I_1STPlayerActions m__1STPlayerActionsCallbackInterface;
    private readonly InputAction m__1STPlayer__1STMove;
    public struct _1STPlayerActions
    {
        private @InputManager m_Wrapper;
        public _1STPlayerActions(@InputManager wrapper) { m_Wrapper = wrapper; }
        public InputAction @_1STMove => m_Wrapper.m__1STPlayer__1STMove;
        public InputActionMap Get() { return m_Wrapper.m__1STPlayer; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(_1STPlayerActions set) { return set.Get(); }
        public void SetCallbacks(I_1STPlayerActions instance)
        {
            if (m_Wrapper.m__1STPlayerActionsCallbackInterface != null)
            {
                @_1STMove.started -= m_Wrapper.m__1STPlayerActionsCallbackInterface.On_1STMove;
                @_1STMove.performed -= m_Wrapper.m__1STPlayerActionsCallbackInterface.On_1STMove;
                @_1STMove.canceled -= m_Wrapper.m__1STPlayerActionsCallbackInterface.On_1STMove;
            }
            m_Wrapper.m__1STPlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @_1STMove.started += instance.On_1STMove;
                @_1STMove.performed += instance.On_1STMove;
                @_1STMove.canceled += instance.On_1STMove;
            }
        }
    }
    public _1STPlayerActions @_1STPlayer => new _1STPlayerActions(this);

    // 2NDPlayer
    private readonly InputActionMap m__2NDPlayer;
    private I_2NDPlayerActions m__2NDPlayerActionsCallbackInterface;
    private readonly InputAction m__2NDPlayer__2NDMove;
    public struct _2NDPlayerActions
    {
        private @InputManager m_Wrapper;
        public _2NDPlayerActions(@InputManager wrapper) { m_Wrapper = wrapper; }
        public InputAction @_2NDMove => m_Wrapper.m__2NDPlayer__2NDMove;
        public InputActionMap Get() { return m_Wrapper.m__2NDPlayer; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(_2NDPlayerActions set) { return set.Get(); }
        public void SetCallbacks(I_2NDPlayerActions instance)
        {
            if (m_Wrapper.m__2NDPlayerActionsCallbackInterface != null)
            {
                @_2NDMove.started -= m_Wrapper.m__2NDPlayerActionsCallbackInterface.On_2NDMove;
                @_2NDMove.performed -= m_Wrapper.m__2NDPlayerActionsCallbackInterface.On_2NDMove;
                @_2NDMove.canceled -= m_Wrapper.m__2NDPlayerActionsCallbackInterface.On_2NDMove;
            }
            m_Wrapper.m__2NDPlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @_2NDMove.started += instance.On_2NDMove;
                @_2NDMove.performed += instance.On_2NDMove;
                @_2NDMove.canceled += instance.On_2NDMove;
            }
        }
    }
    public _2NDPlayerActions @_2NDPlayer => new _2NDPlayerActions(this);
    public interface I_1STPlayerActions
    {
        void On_1STMove(InputAction.CallbackContext context);
    }
    public interface I_2NDPlayerActions
    {
        void On_2NDMove(InputAction.CallbackContext context);
    }
}
