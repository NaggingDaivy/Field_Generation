﻿using UnityEngine;
using System.Collections;

public class Creature : BasePlayer
{

    private Animator _Animator;

	// Use this for initialization
	void Start ()
	{
        DisableInput();
	    _Animator = GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {

	    if (_inputEnabled)
	    {
            if (Input.GetKeyUp(KeyCode.JoystickButton0)
            && !_Animator.GetCurrentAnimatorStateInfo(0).IsName("jump_state"))
            {
                _Animator.SetTrigger("jump_trigger");
            }

            CheckChangePlayer();
	    }
        
	
	}
}
