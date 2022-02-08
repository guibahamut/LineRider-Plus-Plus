// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/MouseControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @MouseControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @MouseControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MouseControls"",
    ""maps"": [
        {
            ""name"": ""Mouse"",
            ""id"": ""8f3e3a3d-59ef-4994-8e03-9eaf6f2480ce"",
            ""actions"": [
                {
                    ""name"": ""Click"",
                    ""type"": ""Button"",
                    ""id"": ""77f6d99e-44cf-4b3a-9b7e-969009df734d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Position"",
                    ""type"": ""PassThrough"",
                    ""id"": ""3d8f587e-7879-4dc2-9369-77c4ba05c6f1"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Erase"",
                    ""type"": ""Button"",
                    ""id"": ""c47100cc-b681-4608-b7f9-c2589846ceb8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Zoom"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f4acf17f-dad1-481f-a745-5bad221cbc52"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": ""Invert"",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""112c1ef4-7dfb-496a-9033-7d2bc4eedfc9"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aa88dca2-26a4-405a-9714-17a200c67854"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Position"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6ee7a981-e619-4de7-a300-003379eb9345"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Erase"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a1b7b90b-febc-48e3-8800-b849e092018e"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Mouse
        m_Mouse = asset.FindActionMap("Mouse", throwIfNotFound: true);
        m_Mouse_Click = m_Mouse.FindAction("Click", throwIfNotFound: true);
        m_Mouse_Position = m_Mouse.FindAction("Position", throwIfNotFound: true);
        m_Mouse_Erase = m_Mouse.FindAction("Erase", throwIfNotFound: true);
        m_Mouse_Zoom = m_Mouse.FindAction("Zoom", throwIfNotFound: true);
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

    // Mouse
    private readonly InputActionMap m_Mouse;
    private IMouseActions m_MouseActionsCallbackInterface;
    private readonly InputAction m_Mouse_Click;
    private readonly InputAction m_Mouse_Position;
    private readonly InputAction m_Mouse_Erase;
    private readonly InputAction m_Mouse_Zoom;
    public struct MouseActions
    {
        private @MouseControls m_Wrapper;
        public MouseActions(@MouseControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Click => m_Wrapper.m_Mouse_Click;
        public InputAction @Position => m_Wrapper.m_Mouse_Position;
        public InputAction @Erase => m_Wrapper.m_Mouse_Erase;
        public InputAction @Zoom => m_Wrapper.m_Mouse_Zoom;
        public InputActionMap Get() { return m_Wrapper.m_Mouse; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MouseActions set) { return set.Get(); }
        public void SetCallbacks(IMouseActions instance)
        {
            if (m_Wrapper.m_MouseActionsCallbackInterface != null)
            {
                @Click.started -= m_Wrapper.m_MouseActionsCallbackInterface.OnClick;
                @Click.performed -= m_Wrapper.m_MouseActionsCallbackInterface.OnClick;
                @Click.canceled -= m_Wrapper.m_MouseActionsCallbackInterface.OnClick;
                @Position.started -= m_Wrapper.m_MouseActionsCallbackInterface.OnPosition;
                @Position.performed -= m_Wrapper.m_MouseActionsCallbackInterface.OnPosition;
                @Position.canceled -= m_Wrapper.m_MouseActionsCallbackInterface.OnPosition;
                @Erase.started -= m_Wrapper.m_MouseActionsCallbackInterface.OnErase;
                @Erase.performed -= m_Wrapper.m_MouseActionsCallbackInterface.OnErase;
                @Erase.canceled -= m_Wrapper.m_MouseActionsCallbackInterface.OnErase;
                @Zoom.started -= m_Wrapper.m_MouseActionsCallbackInterface.OnZoom;
                @Zoom.performed -= m_Wrapper.m_MouseActionsCallbackInterface.OnZoom;
                @Zoom.canceled -= m_Wrapper.m_MouseActionsCallbackInterface.OnZoom;
            }
            m_Wrapper.m_MouseActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Click.started += instance.OnClick;
                @Click.performed += instance.OnClick;
                @Click.canceled += instance.OnClick;
                @Position.started += instance.OnPosition;
                @Position.performed += instance.OnPosition;
                @Position.canceled += instance.OnPosition;
                @Erase.started += instance.OnErase;
                @Erase.performed += instance.OnErase;
                @Erase.canceled += instance.OnErase;
                @Zoom.started += instance.OnZoom;
                @Zoom.performed += instance.OnZoom;
                @Zoom.canceled += instance.OnZoom;
            }
        }
    }
    public MouseActions @Mouse => new MouseActions(this);
    public interface IMouseActions
    {
        void OnClick(InputAction.CallbackContext context);
        void OnPosition(InputAction.CallbackContext context);
        void OnErase(InputAction.CallbackContext context);
        void OnZoom(InputAction.CallbackContext context);
    }
}
