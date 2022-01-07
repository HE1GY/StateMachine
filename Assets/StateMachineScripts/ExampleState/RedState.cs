using System;
using System.Collections;
using System.Collections.Generic;
using StateMachineScripts;
using UnityEngine;

public class RedState : State
{
    [SerializeField] private float _speed;
    
    [SerializeField]private SpriteRenderer _spriteRendere;

    private void OnEnable()
    {
        _spriteRendere.color=Color.red;
    }

    /*private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position,Target.transform.position,_speed*Time.deltaTime);
    }*/
}
