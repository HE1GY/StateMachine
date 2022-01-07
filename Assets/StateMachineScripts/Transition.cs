using UnityEngine;

namespace StateMachineScripts
{
    public abstract class Transition:MonoBehaviour
    {
        [SerializeField] private State _targetState;
        public State TargetState => _targetState;
        protected GameObject Target { get; private set; }
        public bool NeedTransite { get; protected set; }

        public void Init(GameObject target)
        {
            Target = target;
        }

        protected virtual void OnEnable()
        {   
            NeedTransite = false;
        }
    }
}