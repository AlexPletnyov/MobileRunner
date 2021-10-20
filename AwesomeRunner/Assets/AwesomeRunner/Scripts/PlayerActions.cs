using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
	private Transform _transform;
	private Vector3 savedPosition;
	private Animator animator;

	private void Awake()
	{
		_transform = GetComponent<Transform>();
		animator = GetComponent<Animator>();
	}

	public void SavePosition(Transform point)
	{
		savedPosition = point.position;
	}

	public void LoadSavedPosition()
	{
		_transform.position = savedPosition;
	}

	public void GetDamage()
	{
		animator.SetTrigger("damage");
	}
}
