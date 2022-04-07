using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
	public float moveSpeed = 5f;
	public Rigidbody2D rigidBody2D;
	public Animator animator;
	public Vector2 movement;

	public void FixedUpdate()
	{
		rigidBody2D.MovePosition(rigidBody2D.position + movement * moveSpeed * Time.fixedDeltaTime);
	}

	void OnMove(InputValue inputValue)
	{
		movement = inputValue.Get<Vector2>();
		animator.SetFloat("Horizontal", movement.x);
		animator.SetFloat("Vertical", movement.y);
		animator.SetFloat("Speed", movement.sqrMagnitude);
        if (movement.x==1)
        {
			GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
			GetComponent<SpriteRenderer>().flipX = false;
		}
	}

	
}