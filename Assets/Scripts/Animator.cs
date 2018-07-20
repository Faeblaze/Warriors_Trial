using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animator : MonoBehaviour
{
    Animator animator;
    Rigidbody rigidBody;

    int noOfClicks;
    bool cancanClick;



	// Use this for initialization
	void Start ()
    {
        animator = GetComponent<Animator>();
        rigidBody = GetComponent<Rigidbody>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
