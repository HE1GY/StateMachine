using System;
using System.Collections;
using System.Collections.Generic;
using StateMachineScripts;
using UnityEngine;

public class DistanceTransition : Transition
{
    [SerializeField] private float _transitionRange;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            NeedTransite = true;
        }
    }
}
