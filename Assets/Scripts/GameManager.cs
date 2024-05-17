using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public SlotSO x;
	public SlotSO o;
	public SlotSO[,] gamingMatrix;
	public Transform[,] spawnPositions;
	public static bool gameStatus;


	private void OnEnable()
	{
		gameStatus = true;
		gamingMatrix = new SlotSO[3, 3];
		spawnPositions = new Transform[3, 3];
	}





	public void SpawnItem(Transform transform)
	{
		if (transform != null)
		{
			if (gameStatus == true)
			{
				Instantiate(x.transform, transform.position,Quaternion.identity);
			}
			else
			{
				Instantiate(o.transform, transform.position, Quaternion.identity);
			}

			gameStatus = !gameStatus;
		}
	}


}
