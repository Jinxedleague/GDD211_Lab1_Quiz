﻿using UnityEngine;

/// <summary>
/// Control Puppy 2 by setting parameter values on the animator and using a blend tree to control the motion.
/// This is the type of animation seen in the Lab 1 project folder: "3. Blend Trees".
/// </summary>

public class BlendTree : MonoBehaviour
{
	[SerializeField] private Animator puppy2Animator;
	private float speed;

	private void Update()
	{
		if (Input.GetAxisRaw("Vertical") > 0f) //Walk
		{
			puppy2Animator.SetBool("isWalking", true);
		}
		else //Idle
		{
			puppy2Animator.SetBool("isWalking", false);
		}

		transform.position += new Vector3(Time.deltaTime * 0.32f * speed, 0f);
	}
}
