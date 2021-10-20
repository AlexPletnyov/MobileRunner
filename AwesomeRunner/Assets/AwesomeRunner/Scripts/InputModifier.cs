using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputModifier : MonoBehaviour
{
	public float speed;
	public MoveType moveType;

	private Player player;
	private Vector2 directionalInput;

	private void Awake()
	{
		player = GetComponent<Player>();
	}

	private void Update()
	{
		Move();
		Jump();
	}

	private void Move()
	{
		switch (moveType)
		{
			case MoveType.Manual:
				directionalInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
				player.SetDirectionalInput(directionalInput * speed);
				break;

			case MoveType.Right:
				player.SetDirectionalInput(Vector2.left * speed);
				break;

			case MoveType.Left:
				player.SetDirectionalInput(Vector2.right * speed);
				break;
		}
	}

	private void Jump()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			player.OnJumpInputDown();
		}
		if (Input.GetKeyUp(KeyCode.Space))
		{
			player.OnJumpInputUp();
		}
	}
}

public enum MoveType
{
	Manual,
	Right,
	Left
}
