﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class witchMovementLogic : MonoBehaviour {


    private Animator animator;
	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Y"))
        {
            animator.Play("hammer_attackString01");
        }
	}
}
