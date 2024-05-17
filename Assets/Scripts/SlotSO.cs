using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Slot", menuName = "ScriptableObjects/CreateNewSlot", order = 1)]
public class SlotSO : ScriptableObject
{
	public string value
	{
		get { return Value; }
		set { Value = value; }
	}
	public Transform transform
	{
		get { return Transform; }
		set { Transform = value; }
	}


	public string Value;
	public Transform Transform;
}
