
using System;
using System.Collections;
using System.Collections.Generic;
using StateMachineScripts;
using UnityEngine;
using DG.Tweening;

public class BlackState : State
{
    [SerializeField] private SpriteRenderer _spriteRendere;
    
    private void OnEnable()
    {
        _spriteRendere.color=Color.black;
    }

    
}
