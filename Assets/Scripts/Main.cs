// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Main.inputactions'

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
                },
                {
                    ""name"": ""Use"",
                    ""type"": ""Button"",
                    ""id"": ""c2527648-a900-47cf-8933-18ee0e01fe98"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Menu"",
                    ""type"": ""Button"",
                    ""id"": ""a01c606c-2b33-4a88-bf69-dcb8dc7fb160"",
                    ""expectedControlType"": ""Button"",
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
                    ""id"": ""e771e929-f7c2-4246-b764-ddf8da885ae3"",
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
                    ""id"": ""6b5c6122-a7d7-470d-98e4-f8a026994732"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""9623cc6a-4939-4dad-bd28-f9813021d00c"",
                    ""path"": ""<Keyboard>/rightArrow"",
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
                    ""id"": ""9add0d11-46a0-417a-8e96-ecdcd16e743a"",
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
                    ""id"": ""8daec783-c382-4875-bfd0-a0bad394fdca"",
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
                    ""id"": ""034b6360-aef5-442d-812c-0e635c3d57b9"",
                    ""path"": ""<Keyboard>/upArrow"",
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
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""22b0635b-1996-4b25-aaed-ad5653ab9d60"",
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
                    ""id"": ""ab13dd16-aea7-410e-9969-9db3bf6877c3"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BF"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""f337960b-42f7-4428-8eac-cd764e2f1d8d"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BF"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""3d7ca3a9-4cf3-4764-9612-30d925a8962f"",
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
                    ""id"": ""6e9e0892-b257-4820-9c2d-f0d7e707c6ca"",
                    ""path"": ""<Keyboard>/comma"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BF"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""3d6523f2-b29c-4bb3-9966-def6fd0898a3"",
                    ""path"": ""<Keyboard>/period"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BF"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""941893a9-55c4-4bd2-9914-4d6d46b0e47c"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Use"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0737c0c5-948a-463a-a4bd-32a351ed6d8b"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Use"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0e8ace8f-548a-4eaf-a8b8-8d7777049ad3"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Use"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""607f6493-5931-402c-935b-200ac55d684c"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
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
        m_mov_Use = m_mov.FindAction("Use", throwIfNotFound: true);
        m_mov_Menu = m_mov.FindAction("Menu", throwIfNotFound: true);
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
    private readonly InputAction m_mov_Use;
    private readonly InputAction m_mov_Menu;
    public struct MovActions
    {
        private @Main m_Wrapper;
        public MovActions(@Main wrapper) { m_Wrapper = wrapper; }
        public InputAction @LR => m_Wrapper.m_mov_LR;
        public InputAction @Jump => m_Wrapper.m_mov_Jump;
        public InputAction @BF => m_Wrapper.m_mov_BF;
        public InputAction @Use => m_Wrapper.m_mov_Use;
        public InputAction @Menu => m_Wrapper.m_mov_Menu;
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
                @Use.started -= m_Wrapper.m_MovActionsCallbackInterface.OnUse;
                @Use.performed -= m_Wrapper.m_MovActionsCallbackInterface.OnUse;
                @Use.canceled -= m_Wrapper.m_MovActionsCallbackInterface.OnUse;
                @Menu.started -= m_Wrapper.m_MovActionsCallbackInterface.OnMenu;
                @Menu.performed -= m_Wrapper.m_MovActionsCallbackInterface.OnMenu;
                @Menu.canceled -= m_Wrapper.m_MovActionsCallbackInterface.OnMenu;
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
                @Use.started += instance.OnUse;
                @Use.performed += instance.OnUse;
                @Use.canceled += instance.OnUse;
                @Menu.started += instance.OnMenu;
                @Menu.performed += instance.OnMenu;
                @Menu.canceled += instance.OnMenu;
            }
        }
    }
    public MovActions @mov => new MovActions(this);
    public interface IMovActions
    {
        void OnLR(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnBF(InputAction.CallbackContext context);
        void OnUse(InputAction.CallbackContext context);
        void OnMenu(InputAction.CallbackContext context);
    }
}
