//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Articy.Unity;
using Articy.Unity.Interfaces;
using System;
using System.Collections;
using UnityEngine;


namespace Articy.Jam.GlobalVariables
{
    
    
    [Serializable()]
    public class GameState : IArticyNamespace
    {
        
        [SerializeField()]
        private BaseGlobalVariables _VariableStorage;
        
        // 
        public bool end_conversation
        {
            get
            {
                return _VariableStorage.Internal_GetVariableValueBoolean(0);
            }
            set
            {
                _VariableStorage.Internal_SetVariableValueBoolean(0, value);
            }
        }
        
        // 
        public bool talked_to_collega
        {
            get
            {
                return _VariableStorage.Internal_GetVariableValueBoolean(1);
            }
            set
            {
                _VariableStorage.Internal_SetVariableValueBoolean(1, value);
            }
        }
        
        // 
        public bool fireproof_suit
        {
            get
            {
                return _VariableStorage.Internal_GetVariableValueBoolean(2);
            }
            set
            {
                _VariableStorage.Internal_SetVariableValueBoolean(2, value);
            }
        }
        
        // 
        public bool fire_hose
        {
            get
            {
                return _VariableStorage.Internal_GetVariableValueBoolean(3);
            }
            set
            {
                _VariableStorage.Internal_SetVariableValueBoolean(3, value);
            }
        }
        
        // 
        public bool training
        {
            get
            {
                return _VariableStorage.Internal_GetVariableValueBoolean(4);
            }
            set
            {
                _VariableStorage.Internal_SetVariableValueBoolean(4, value);
            }
        }
        
        // 
        public bool fireproof_suit_talked
        {
            get
            {
                return _VariableStorage.Internal_GetVariableValueBoolean(5);
            }
            set
            {
                _VariableStorage.Internal_SetVariableValueBoolean(5, value);
            }
        }
        
        // 
        public bool fire_hose_talked
        {
            get
            {
                return _VariableStorage.Internal_GetVariableValueBoolean(6);
            }
            set
            {
                _VariableStorage.Internal_SetVariableValueBoolean(6, value);
            }
        }
        
        // 
        public bool allow_take_hose
        {
            get
            {
                return _VariableStorage.Internal_GetVariableValueBoolean(7);
            }
            set
            {
                _VariableStorage.Internal_SetVariableValueBoolean(7, value);
            }
        }
        
        // 
        public bool touch_hose
        {
            get
            {
                return _VariableStorage.Internal_GetVariableValueBoolean(8);
            }
            set
            {
                _VariableStorage.Internal_SetVariableValueBoolean(8, value);
            }
        }
        
        // 
        public bool training_complete
        {
            get
            {
                return _VariableStorage.Internal_GetVariableValueBoolean(9);
            }
            set
            {
                _VariableStorage.Internal_SetVariableValueBoolean(9, value);
            }
        }
        
        public void RegisterVariables(BaseGlobalVariables aStorage)
        {
            _VariableStorage = aStorage;
            aStorage.RegisterVariable("GameState.end_conversation", false);
            aStorage.RegisterVariable("GameState.talked_to_collega", false);
            aStorage.RegisterVariable("GameState.fireproof_suit", false);
            aStorage.RegisterVariable("GameState.fire_hose", false);
            aStorage.RegisterVariable("GameState.training", false);
            aStorage.RegisterVariable("GameState.fireproof_suit_talked", false);
            aStorage.RegisterVariable("GameState.fire_hose_talked", false);
            aStorage.RegisterVariable("GameState.allow_take_hose", false);
            aStorage.RegisterVariable("GameState.touch_hose", false);
            aStorage.RegisterVariable("GameState.training_complete", false);
        }
    }
}
