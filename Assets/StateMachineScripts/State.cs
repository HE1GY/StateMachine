using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StateMachineScripts
{
    public abstract class State : MonoBehaviour
    {
        [SerializeField] private List<Transition> _transition;
        
        protected GameObject Target { get; set; }//
        
        public void Enter(GameObject target)
        {
            if (enabled == false)
            {
                Target = target;//
                enabled = true;
                foreach (Transition transition in _transition)
                {
                    transition.enabled = true;
                    transition.Init(Target);//
                }
            }
        }
        
        public void Exit()
        {
            if (enabled)
            {
                foreach (var transition in _transition)
                {
                    transition.enabled = false;
                }
                enabled = false;
            }
        }

        public State GetNextState()
        {
            foreach (var transition in _transition)
                if (transition.NeedTransite)return transition.TargetState;
            
            return null;
        }
    }
}

