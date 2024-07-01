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
    [CreateAssetMenu(fileName="ArticyGlobalVariables", menuName="Create GlobalVariables", order=620)]
    public class ArticyGlobalVariables : BaseGlobalVariables
    {
        
        [SerializeField()]
        [HideInInspector()]
        private GameState mGameState = new GameState();
        
        #region Initialize static VariableName set
        static ArticyGlobalVariables()
        {
            variableNames.Add("GameState.end_conversation");
            variableNames.Add("GameState.talked_to_collega");
            variableNames.Add("GameState.fireproof_suit");
            variableNames.Add("GameState.fire_hose");
            variableNames.Add("GameState.training");
            variableNames.Add("GameState.fireproof_suit_talked");
            variableNames.Add("GameState.fire_hose_talked");
            variableNames.Add("GameState.allow_take_hose");
            variableNames.Add("GameState.touch_hose");
            variableNames.Add("GameState.training_complete");
            variableNames.Add("GameState.talked_to_collega2");
            variableNames.Add("GameState.start_count");
            variableNames.Add("GameState.counter");
            variableNames.Add("GameState.good_talk");
            variableNames.Add("GameState.bad_talk");
            variableNames.Add("GameState.another_way");
            variableNames.Add("GameState.destroy_fire_in_window");
            variableNames.Add("GameState.gas_mask");
            variableNames.Add("GameState.hostage_on");
            variableNames.Add("GameState.for_what");
            variableNames.Add("GameState.done_with_street");
            variableNames.Add("GameState.room_6_done");
            variableNames.Add("GameState.room_7_done");
            variableNames.Add("GameState.room_8_done");
            variableNames.Add("GameState.move_to_the_next_location");
            variableNames.Add("GameState.best_choice");
        }
        #endregion
        
        public GameState GameState
        {
            get
            {
                return mGameState;
            }
        }
        
        public static ArticyGlobalVariables Default
        {
            get
            {
                return ((ArticyGlobalVariables)(Articy.Unity.ArticyDatabase.DefaultGlobalVariables));
            }
        }
        
        public override void Init()
        {
            GameState.RegisterVariables(this);
        }
        
        public static ArticyGlobalVariables CreateGlobalVariablesClone()
        {
            return Articy.Unity.BaseGlobalVariables.CreateGlobalVariablesClone<ArticyGlobalVariables>();
        }
    }
}
