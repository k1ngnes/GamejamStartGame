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
using System.Collections.Generic;
using UnityEngine;


namespace Articy.Jam.GlobalVariables
{
    
    
    [Articy.Unity.ArticyCodeGenerationHashAttribute(638553369016560435)]
    public class ArticyScriptFragments : BaseScriptFragments, ISerializationCallbackReceiver
    {
        
        #region Fields
        private System.Collections.Generic.Dictionary<uint, System.Func<ArticyGlobalVariables, Articy.Unity.IBaseScriptMethodProvider, bool>> Conditions = new System.Collections.Generic.Dictionary<uint, System.Func<ArticyGlobalVariables, Articy.Unity.IBaseScriptMethodProvider, bool>>();
        
        private System.Collections.Generic.Dictionary<uint, System.Action<ArticyGlobalVariables, Articy.Unity.IBaseScriptMethodProvider>> Instructions = new System.Collections.Generic.Dictionary<uint, System.Action<ArticyGlobalVariables, Articy.Unity.IBaseScriptMethodProvider>>();
        #endregion
        
        #region Script fragments
        /// <summary>
        /// ObjectID: 0x10000000000012F
        /// Articy Object ref: articy://localhost/view/82ca42c8-cef4-4720-86fe-bf7ea1cb5544/72057594037928239?pane=selected&amp;tab=current
        /// </summary>
        public bool Script_0x10000000000012FText(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            return //Первый разговор
aGlobalVariablesState.GameState.talked_to_collega == false && aGlobalVariablesState.GameState.training == false;
        }
        
        /// <summary>
        /// ObjectID: 0x10000000000019E
        /// Articy Object ref: articy://localhost/view/82ca42c8-cef4-4720-86fe-bf7ea1cb5544/72057594037928350?pane=selected&amp;tab=current
        /// </summary>
        public bool Script_0x10000000000019EText(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            return //Последующие разговоры
aGlobalVariablesState.GameState.end_conversation == false && aGlobalVariablesState.GameState.training == false && aGlobalVariablesState.GameState.talked_to_collega == true;
        }
        
        /// <summary>
        /// ObjectID: 0x1000000000001A0
        /// Articy Object ref: articy://localhost/view/82ca42c8-cef4-4720-86fe-bf7ea1cb5544/72057594037928352?pane=selected&amp;tab=current
        /// </summary>
        public bool Script_0x1000000000001A0Text(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            return //Разговор после окончания всех взаимодействий
aGlobalVariablesState.GameState.end_conversation == true && aGlobalVariablesState.GameState.training == false && aGlobalVariablesState.GameState.talked_to_collega == true;
        }
        
        /// <summary>
        /// ObjectID: 0x1000000000003CA
        /// Articy Object ref: articy://localhost/view/82ca42c8-cef4-4720-86fe-bf7ea1cb5544/72057594037928906?pane=selected&amp;tab=current
        /// </summary>
        public bool Script_0x1000000000003CAText(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            return //После прохождения обучения
aGlobalVariablesState.GameState.training == true;
        }
        
        /// <summary>
        /// ObjectID: 0x100000000000135
        /// Articy Object ref: articy://localhost/view/82ca42c8-cef4-4720-86fe-bf7ea1cb5544/72057594037928245?pane=selected&amp;tab=current
        /// </summary>
        public bool Script_0x100000000000135Text(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            return //Получил шланг и костюм
true;
        }
        
        /// <summary>
        /// ObjectID: 0x1000000000001B4
        /// Articy Object ref: articy://localhost/view/82ca42c8-cef4-4720-86fe-bf7ea1cb5544/72057594037928372?pane=selected&amp;tab=current
        /// </summary>
        public bool Script_0x1000000000001B4Text(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            return //Получил шланг

true;
        }
        
        /// <summary>
        /// ObjectID: 0x1000000000001B5
        /// Articy Object ref: articy://localhost/view/82ca42c8-cef4-4720-86fe-bf7ea1cb5544/72057594037928373?pane=selected&amp;tab=current
        /// </summary>
        public bool Script_0x1000000000001B5Text(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            return //Получил костюм

true;
        }
        
        /// <summary>
        /// ObjectID: 0x1000000000001B6
        /// Articy Object ref: articy://localhost/view/82ca42c8-cef4-4720-86fe-bf7ea1cb5544/72057594037928374?pane=selected&amp;tab=current
        /// </summary>
        public bool Script_0x1000000000001B6Text(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            return //Ничего не сделал

true;
        }
        
        /// <summary>
        /// ObjectID: 0x1000000000001B7
        /// Articy Object ref: articy://localhost/view/82ca42c8-cef4-4720-86fe-bf7ea1cb5544/72057594037928375?pane=selected&amp;tab=current
        /// </summary>
        public bool Script_0x1000000000001B7Text(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            return //Закончил все взаимодействие на уровне

true;
        }
        
        /// <summary>
        /// ObjectID: 0x10000000000013B
        /// Articy Object ref: articy://localhost/view/82ca42c8-cef4-4720-86fe-bf7ea1cb5544/72057594037928251?pane=selected&amp;tab=current
        /// </summary>
        public bool Script_0x10000000000013BText(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            return //Поговорил с коллегой
true;
        }
        
        /// <summary>
        /// ObjectID: 0x100000000000154
        /// Articy Object ref: articy://localhost/view/82ca42c8-cef4-4720-86fe-bf7ea1cb5544/72057594037928276?pane=selected&amp;tab=current
        /// </summary>
        public bool Script_0x100000000000154Text(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            return //Не поговорил с коллегой

true;
        }
        
        /// <summary>
        /// ObjectID: 0x10000000000013C
        /// Articy Object ref: articy://localhost/view/82ca42c8-cef4-4720-86fe-bf7ea1cb5544/72057594037928252?pane=selected&amp;tab=current
        /// </summary>
        public void Script_0x10000000000013CText(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            aGlobalVariablesState.GameState.fire_hose = true;
        }
        
        /// <summary>
        /// ObjectID: 0x100000000000141
        /// Articy Object ref: articy://localhost/view/82ca42c8-cef4-4720-86fe-bf7ea1cb5544/72057594037928257?pane=selected&amp;tab=current
        /// </summary>
        public bool Script_0x100000000000141Text(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            return //Поговорил с коллегой
true;
        }
        
        /// <summary>
        /// ObjectID: 0x10000000000015C
        /// Articy Object ref: articy://localhost/view/82ca42c8-cef4-4720-86fe-bf7ea1cb5544/72057594037928284?pane=selected&amp;tab=current
        /// </summary>
        public bool Script_0x10000000000015CText(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            return //Не поговорил с коллегой
true;
        }
        
        /// <summary>
        /// ObjectID: 0x100000000000142
        /// Articy Object ref: articy://localhost/view/82ca42c8-cef4-4720-86fe-bf7ea1cb5544/72057594037928258?pane=selected&amp;tab=current
        /// </summary>
        public void Script_0x100000000000142Text(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            aGlobalVariablesState.GameState.fireproof_suit = true;
        }
        
        /// <summary>
        /// ObjectID: 0x10000000000050C
        /// Articy Object ref: articy://localhost/view/82ca42c8-cef4-4720-86fe-bf7ea1cb5544/72057594037929228?pane=selected&amp;tab=current
        /// </summary>
        public void Script_0x10000000000050CText(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            //Переход в след локу
;
        }
        
        /// <summary>
        /// ObjectID: 0x1000000000003B8
        /// Articy Object ref: articy://localhost/view/82ca42c8-cef4-4720-86fe-bf7ea1cb5544/72057594037928888?pane=selected&amp;tab=current
        /// </summary>
        public void Script_0x1000000000003B8Text(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            aGlobalVariablesState.GameState.training = false;;
        }
        
        /// <summary>
        /// ObjectID: 0x100000000000384
        /// Articy Object ref: articy://localhost/view/82ca42c8-cef4-4720-86fe-bf7ea1cb5544/72057594037928836?pane=selected&amp;tab=current
        /// </summary>
        public void Script_0x100000000000384Text(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            aGlobalVariablesState.GameState.training = false;
aGlobalVariablesState.GameState.fire_hose_talked = true;;
        }
        
        /// <summary>
        /// ObjectID: 0x100000000000380
        /// Articy Object ref: articy://localhost/view/82ca42c8-cef4-4720-86fe-bf7ea1cb5544/72057594037928832?pane=selected&amp;tab=current
        /// </summary>
        public void Script_0x100000000000380Text(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            aGlobalVariablesState.GameState.fire_hose_talked = true;;
        }
        
        /// <summary>
        /// ObjectID: 0x10000000000039A
        /// Articy Object ref: articy://localhost/view/82ca42c8-cef4-4720-86fe-bf7ea1cb5544/72057594037928858?pane=selected&amp;tab=current
        /// </summary>
        public void Script_0x10000000000039AText(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            aGlobalVariablesState.GameState.training = true;
        }
        
        /// <summary>
        /// ObjectID: 0x1000000000002E3
        /// Articy Object ref: articy://localhost/view/82ca42c8-cef4-4720-86fe-bf7ea1cb5544/72057594037928675?pane=selected&amp;tab=current
        /// </summary>
        public void Script_0x1000000000002E3Text(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            aGlobalVariablesState.GameState.talked_to_collega = true;
aGlobalVariablesState.GameState.end_conversation = true;;
        }
        
        /// <summary>
        /// ObjectID: 0x1000000000002C9
        /// Articy Object ref: articy://localhost/view/82ca42c8-cef4-4720-86fe-bf7ea1cb5544/72057594037928649?pane=selected&amp;tab=current
        /// </summary>
        public void Script_0x1000000000002C9Text(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            aGlobalVariablesState.GameState.fireproof_suit_talked = true;;
        }
        
        /// <summary>
        /// ObjectID: 0x100000000000290
        /// Articy Object ref: articy://localhost/view/82ca42c8-cef4-4720-86fe-bf7ea1cb5544/72057594037928592?pane=selected&amp;tab=current
        /// </summary>
        public void Script_0x100000000000290Text(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            aGlobalVariablesState.GameState.talked_to_collega = true;
        }
        
        /// <summary>
        /// ObjectID: 0x100000000000284
        /// Articy Object ref: articy://localhost/view/82ca42c8-cef4-4720-86fe-bf7ea1cb5544/72057594037928580?pane=selected&amp;tab=current
        /// </summary>
        public void Script_0x100000000000284Text(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            aGlobalVariablesState.GameState.talked_to_collega = true;
        }
        
        /// <summary>
        /// ObjectID: 0x10000000000032F
        /// Articy Object ref: articy://localhost/view/82ca42c8-cef4-4720-86fe-bf7ea1cb5544/72057594037928751?pane=selected&amp;tab=current
        /// </summary>
        public bool Script_0x10000000000032FExpression(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            return aGlobalVariablesState.GameState.fireproof_suit == true && aGlobalVariablesState.GameState.fireproof_suit_talked == false;
        }
        
        /// <summary>
        /// ObjectID: 0x10000000000032A
        /// Articy Object ref: articy://localhost/view/82ca42c8-cef4-4720-86fe-bf7ea1cb5544/72057594037928746?pane=selected&amp;tab=current
        /// </summary>
        public bool Script_0x10000000000032AExpression(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            return aGlobalVariablesState.GameState.fire_hose == true && aGlobalVariablesState.GameState.fire_hose_talked == false;
        }
        
        /// <summary>
        /// ObjectID: 0x100000000000324
        /// Articy Object ref: articy://localhost/view/82ca42c8-cef4-4720-86fe-bf7ea1cb5544/72057594037928740?pane=selected&amp;tab=current
        /// </summary>
        public bool Script_0x100000000000324Expression(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            return aGlobalVariablesState.GameState.fire_hose == true &&
aGlobalVariablesState.GameState.fireproof_suit == true && aGlobalVariablesState.GameState.fire_hose_talked == false && aGlobalVariablesState.GameState.fireproof_suit_talked == false;
        }
        
        /// <summary>
        /// ObjectID: 0x1000000000002CC
        /// Articy Object ref: articy://localhost/view/82ca42c8-cef4-4720-86fe-bf7ea1cb5544/72057594037928652?pane=selected&amp;tab=current
        /// </summary>
        public bool Script_0x1000000000002CCExpression(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            return aGlobalVariablesState.GameState.fire_hose == true && aGlobalVariablesState.GameState.fireproof_suit == true;
        }
        
        /// <summary>
        /// ObjectID: 0x1000000000002B1
        /// Articy Object ref: articy://localhost/view/82ca42c8-cef4-4720-86fe-bf7ea1cb5544/72057594037928625?pane=selected&amp;tab=current
        /// </summary>
        public bool Script_0x1000000000002B1Expression(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            return aGlobalVariablesState.GameState.fireproof_suit == true;
        }
        
        /// <summary>
        /// ObjectID: 0x10000000000027A
        /// Articy Object ref: articy://localhost/view/82ca42c8-cef4-4720-86fe-bf7ea1cb5544/72057594037928570?pane=selected&amp;tab=current
        /// </summary>
        public bool Script_0x10000000000027AExpression(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            return aGlobalVariablesState.GameState.fireproof_suit == false;
        }
        
        /// <summary>
        /// ObjectID: 0x10000000000027E
        /// Articy Object ref: articy://localhost/view/82ca42c8-cef4-4720-86fe-bf7ea1cb5544/72057594037928574?pane=selected&amp;tab=current
        /// </summary>
        public void Script_0x10000000000027EText(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            aGlobalVariablesState.GameState.talked_to_collega = true;
        }
        
        /// <summary>
        /// ObjectID: 0x10000000000014E
        /// Articy Object ref: articy://localhost/view/82ca42c8-cef4-4720-86fe-bf7ea1cb5544/72057594037928270?pane=selected&amp;tab=current
        /// </summary>
        public bool Script_0x10000000000014EExpression(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            return aGlobalVariablesState.GameState.talked_to_collega == true;
        }
        
        /// <summary>
        /// ObjectID: 0x100000000000156
        /// Articy Object ref: articy://localhost/view/82ca42c8-cef4-4720-86fe-bf7ea1cb5544/72057594037928278?pane=selected&amp;tab=current
        /// </summary>
        public bool Script_0x100000000000156Expression(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            return aGlobalVariablesState.GameState.talked_to_collega == true;
        }
        
        /// <summary>
        /// ObjectID: 0x100000000000248
        /// Articy Object ref: articy://localhost/view/82ca42c8-cef4-4720-86fe-bf7ea1cb5544/72057594037928520?pane=selected&amp;tab=current
        /// </summary>
        public bool Script_0x100000000000248Expression(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            return aGlobalVariablesState.GameState.fireproof_suit == true;
        }
        
        /// <summary>
        /// ObjectID: 0x10000000000023E
        /// Articy Object ref: articy://localhost/view/82ca42c8-cef4-4720-86fe-bf7ea1cb5544/72057594037928510?pane=selected&amp;tab=current
        /// </summary>
        public bool Script_0x10000000000023EExpression(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            return aGlobalVariablesState.GameState.fire_hose == true && aGlobalVariablesState.GameState.fireproof_suit == true;
        }
        
        /// <summary>
        /// ObjectID: 0x1000000000001C1
        /// Articy Object ref: articy://localhost/view/82ca42c8-cef4-4720-86fe-bf7ea1cb5544/72057594037928385?pane=selected&amp;tab=current
        /// </summary>
        public bool Script_0x1000000000001C1Expression(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            return aGlobalVariablesState.GameState.end_conversation == true && aGlobalVariablesState.GameState.fire_hose == true && aGlobalVariablesState.GameState.fireproof_suit == true;
        }
        
        /// <summary>
        /// ObjectID: 0x1000000000001BB
        /// Articy Object ref: articy://localhost/view/82ca42c8-cef4-4720-86fe-bf7ea1cb5544/72057594037928379?pane=selected&amp;tab=current
        /// </summary>
        public bool Script_0x1000000000001BBExpression(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            return aGlobalVariablesState.GameState.fireproof_suit == true;
        }
        
        /// <summary>
        /// ObjectID: 0x1000000000001AF
        /// Articy Object ref: articy://localhost/view/82ca42c8-cef4-4720-86fe-bf7ea1cb5544/72057594037928367?pane=selected&amp;tab=current
        /// </summary>
        public bool Script_0x1000000000001AFExpression(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            return aGlobalVariablesState.GameState.fire_hose == true;
        }
        
        /// <summary>
        /// ObjectID: 0x1000000000001AA
        /// Articy Object ref: articy://localhost/view/82ca42c8-cef4-4720-86fe-bf7ea1cb5544/72057594037928362?pane=selected&amp;tab=current
        /// </summary>
        public bool Script_0x1000000000001AAExpression(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            return aGlobalVariablesState.GameState.fire_hose == true && aGlobalVariablesState.GameState.fireproof_suit == true;
        }
        
        /// <summary>
        /// ObjectID: 0x100000000000243
        /// Articy Object ref: articy://localhost/view/82ca42c8-cef4-4720-86fe-bf7ea1cb5544/72057594037928515?pane=selected&amp;tab=current
        /// </summary>
        public bool Script_0x100000000000243Expression(ArticyGlobalVariables aGlobalVariablesState, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            return aGlobalVariablesState.GameState.fire_hose == true;
        }
        #endregion
        
        #region Unity serialization
        public override void OnBeforeSerialize()
        {
        }
        
        public override void OnAfterDeserialize()
        {
            Conditions = new System.Collections.Generic.Dictionary<uint, System.Func<ArticyGlobalVariables, Articy.Unity.IBaseScriptMethodProvider, bool>>();
            Instructions = new System.Collections.Generic.Dictionary<uint, System.Action<ArticyGlobalVariables, Articy.Unity.IBaseScriptMethodProvider>>();
            Conditions.Add(1u, this.Script_0x10000000000012FText);
            Conditions.Add(2u, this.Script_0x10000000000019EText);
            Conditions.Add(3u, this.Script_0x1000000000001A0Text);
            Conditions.Add(4u, this.Script_0x1000000000003CAText);
            Conditions.Add(5u, this.Script_0x100000000000135Text);
            Conditions.Add(6u, this.Script_0x1000000000001B4Text);
            Conditions.Add(7u, this.Script_0x1000000000001B5Text);
            Conditions.Add(8u, this.Script_0x1000000000001B6Text);
            Conditions.Add(9u, this.Script_0x1000000000001B7Text);
            Conditions.Add(10u, this.Script_0x10000000000013BText);
            Conditions.Add(11u, this.Script_0x100000000000154Text);
            Instructions.Add(12u, this.Script_0x10000000000013CText);
            Conditions.Add(13u, this.Script_0x100000000000141Text);
            Conditions.Add(14u, this.Script_0x10000000000015CText);
            Instructions.Add(15u, this.Script_0x100000000000142Text);
            Instructions.Add(16u, this.Script_0x10000000000050CText);
            Instructions.Add(17u, this.Script_0x1000000000003B8Text);
            Instructions.Add(18u, this.Script_0x100000000000384Text);
            Instructions.Add(19u, this.Script_0x100000000000380Text);
            Instructions.Add(20u, this.Script_0x10000000000039AText);
            Instructions.Add(21u, this.Script_0x1000000000002E3Text);
            Instructions.Add(22u, this.Script_0x1000000000002C9Text);
            Instructions.Add(23u, this.Script_0x100000000000290Text);
            Instructions.Add(24u, this.Script_0x100000000000284Text);
            Conditions.Add(25u, this.Script_0x10000000000032FExpression);
            Conditions.Add(26u, this.Script_0x10000000000032AExpression);
            Conditions.Add(27u, this.Script_0x100000000000324Expression);
            Conditions.Add(28u, this.Script_0x1000000000002CCExpression);
            Conditions.Add(29u, this.Script_0x1000000000002B1Expression);
            Conditions.Add(30u, this.Script_0x10000000000027AExpression);
            Instructions.Add(31u, this.Script_0x10000000000027EText);
            Conditions.Add(32u, this.Script_0x10000000000014EExpression);
            Conditions.Add(33u, this.Script_0x100000000000156Expression);
            Conditions.Add(34u, this.Script_0x100000000000248Expression);
            Conditions.Add(35u, this.Script_0x10000000000023EExpression);
            Conditions.Add(36u, this.Script_0x1000000000001C1Expression);
            Conditions.Add(37u, this.Script_0x1000000000001BBExpression);
            Conditions.Add(38u, this.Script_0x1000000000001AFExpression);
            Conditions.Add(39u, this.Script_0x1000000000001AAExpression);
            Conditions.Add(40u, this.Script_0x100000000000243Expression);
        }
        #endregion
        
        #region Script execution
        public override void CallInstruction(Articy.Unity.Interfaces.IGlobalVariables aGlobalVariables, uint aHandlerId, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            if ((Instructions.ContainsKey(aHandlerId) == false))
            {
                return;
            }
            if ((aMethodProvider != null))
            {
                aMethodProvider.IsCalledInForecast = aGlobalVariables.IsInShadowState;
            }
            Instructions[aHandlerId].Invoke(((ArticyGlobalVariables)(aGlobalVariables)), aMethodProvider);
        }
        
        public override bool CallCondition(Articy.Unity.Interfaces.IGlobalVariables aGlobalVariables, uint aHandlerId, Articy.Unity.IBaseScriptMethodProvider aMethodProvider)
        {
            if ((Conditions.ContainsKey(aHandlerId) == false))
            {
                return true;
            }
            if ((aMethodProvider != null))
            {
                aMethodProvider.IsCalledInForecast = aGlobalVariables.IsInShadowState;
            }
            return Conditions[aHandlerId].Invoke(((ArticyGlobalVariables)(aGlobalVariables)), aMethodProvider);
        }
        #endregion
    }
}
