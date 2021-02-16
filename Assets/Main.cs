// GENERATED AUTOMATICALLY FROM 'Assets/Main.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Main : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Main()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Main"",
    ""maps"": [
        {
            ""name"": ""mov"",
            ""id"": ""0487f01f-e239-4ecc-a090-908720c3457b"",
            ""actions"": [
                {
                    ""name"": ""LR"",
                    ""type"": ""Value"",
                    ""id"": ""7198c41d-0052-4c39-8a81-c01945ec7edb"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Value"",
                    ""id"": ""5c71478b-21a0-4018-a279-6a377bdc09b6"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BF"",
                    ""type"": ""Value"",
                    ""id"": ""38a7b6c4-f399-482c-a949-c7313e22f803"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""00bc9f5d-c589-4585-89e7-db6edfb730eb"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LR"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""773fc6d9-5b0e-4fd4-9b6c-0b8c96af72b3"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""95dd7b97-886e-4cac-8b59-cf1b88162486"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""9141b5c5-0ea2-4d85-8a99-a777e9927309"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""374bf444-2c2c-4fc3-9f77-aa0baf3fc896"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""a7732b7f-cabb-4fae-af20-fb162a6b7d96"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""fd91912d-e9f9-4d41-9e21-73a04706de99"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""bb0d9d8b-1615-4f7a-95c7-575e660c6564"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""29a15a7d-43a2-4e0b-859c-17cf7456dc44"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""90f7a058-d841-422f-8de3-d88849d61e91"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BF"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""1d9cfba6-5845-4a2c-8d64-cfcf139520bc"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BF"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""55191b73-2e7e-4ba0-a5fb-7b908992c5e6"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BF"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // mov
        m_mov = asset.FindActionMap("mov", throwIfNotFound: true);
        m_mov_LR = m_mov.FindAction("LR", throwIfNotFound: true);
        m_mov_Jump = m_mov.FindAction("Jump", throwIfNotFound: true);
        m_mov_BF = m_mov.FindAction("BF", throwIfNotFound: true);
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

    // mov
    private readonly InputActionMap m_mov;
    private IMovActions m_MovActionsCallbackInterface;
    private readonly InputAction m_mov_LR;
    private readonly InputAction m_mov_Jump;
    private readonly InputAction m_mov_BF;
    public struct MovActions
    {
        private @Main m_Wrapper;
        public MovActions(@Main wrapper) { m_Wrapper = wrapper; }
        public InputAction @LR => m_Wrapper.m_mov_LR;
        public InputAction @Jump => m_Wrapper.m_mov_Jump;
        public InputAction @BF => m_Wrapper.m_mov_BF;
        public InputActionMap Get() { return m_Wrapper.m_mov; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovActions set) { return set.Get(); }
        public void SetCallbacks(IMovActions instance)
        {
            if (m_Wrapper.m_MovActionsCallbackInterface != null)
            {
                @LR.started -= m_Wrapper.m_MovActionsCallbackInterface.OnLR;
                @LR.performed -= m_Wrapper.m_MovActionsCallbackInterface.OnLR;
                @LR.canceled -= m_Wrapper.m_MovActionsCallbackInterface.OnLR;
                @Jump.started -= m_Wrapper.m_MovActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_MovActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_MovActionsCallbackInterface.OnJump;
                @BF.started -= m_Wrapper.m_MovActionsCallbackInterface.OnBF;
                @BF.performed -= m_Wrapper.m_MovActionsCallbackInterface.OnBF;
                @BF.canceled -= m_Wrapper.m_MovActionsCallbackInterface.OnBF;
            }
            m_Wrapper.m_MovActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LR.started += instance.OnLR;
                @LR.performed += instance.OnLR;
                @LR.canceled += instance.OnLR;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @BF.started += instance.OnBF;
                @BF.performed += instance.OnBF;
                @BF.canceled += instance.OnBF;
            }
        }
    }
    public MovActions @mov => new MovActions(this);
    public interface IMovActions
    {
        void OnLR(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnBF(InputAction.CallbackContext context);
    }
}
