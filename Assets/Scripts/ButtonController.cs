using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
	[SerializeField] private SpawnPointController spawnPointController;
	[SerializeField] private GameManager gameManager;

	private void Awake()
	{
		spawnPointController = transform.GetComponentInChildren<SpawnPointController>();
	}


	public void ButtonClicked()
	{
		if (spawnPointController.isEmpty)
		{
			Debug.Log(spawnPointController.gameObject);
			gameManager.SpawnItem(spawnPointController.spawnTransform);
			spawnPointController.isEmpty = false;
		}
	}
}
