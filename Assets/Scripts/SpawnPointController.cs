using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointController : MonoBehaviour
{
	public Transform spawnTransform;
    public bool isEmpty;


	private void OnEnable()
	{
		spawnTransform = transform;
	}
}
