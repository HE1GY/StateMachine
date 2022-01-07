using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StateMachineScripts
{
    public class StateMachine : MonoBehaviour
    {
        [SerializeField] private State _startSate;
        [SerializeField] GameObject _target;
        
        private State _currentState;

        public State CurrentState => _currentState;// for later

        private void Start()
        {
            Transite(_startSate);
        }

        private void Update()
        {
            if (_currentState == null) return;
            var nextState = _currentState.GetNextState();
            if (nextState != null) Transite(nextState);
        }

        private void Transite(State nextState)
        {
            if (_currentState != null) _currentState.Exit();

            _currentState = nextState;
            
            if(_currentState!=null)_currentState.Enter(_target);
        }
    }
}

