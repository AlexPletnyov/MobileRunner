using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerTrigger : MonoBehaviour
{
	private PlayerActions playerActions;

	private void Awake()
	{
		playerActions = GetComponent<PlayerActions>();
	}

	private void OnTriggerEnter2D(Collider2D coll)
	{
		if (coll.CompareTag("Enemy"))
		{
			playerActions.LoadSavedPosition();
			playerActions.GetDamage();
		}

		if (coll.CompareTag("SavingArea"))
		{
			playerActions.SavePosition(coll.gameObject.transform.GetChild(0));
		}

		if (coll.CompareTag("FinishArea"))
		{
			SceneManager.LoadScene("title");
		}
	}
}
