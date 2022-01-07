using System;
using System.Collections;
using System.Collections.Generic;
using StateMachineScripts;
using UnityEngine;

public class DistanceTransition_Back : Transition
{
    [SerializeField] private float _transitionRange;
    
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D)||Vector2.Distance(transform.position,Target.transform.position)<3)
        {
            NeedTransite = true;
        }
    }
}
