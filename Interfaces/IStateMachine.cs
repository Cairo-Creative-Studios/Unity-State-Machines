using System.Collections.Generic;
using UnityEngine;

namespace UDT.StateMachines
{
    public interface IStateMachine
    {
        public GameObject gameObject { get; }
        public Tree<StateMachineManager.Reference> stateReferences { get { return StateMachineManager.GetStateMachineReference(this).stateReferences; } set { StateMachineManager.GetStateMachineReference(this).stateReferences = value; } }
        public StateMachineManager.StateBase CurrentState { get{ return StateMachineManager.GetStateMachineReference(this).currentState; } set{ StateMachineManager.GetStateMachineReference(this).currentState = value; }}
    }
}