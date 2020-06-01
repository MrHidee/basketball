using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchDestroy : MonoBehaviour
{

	[SerializeField]
	GameObject ball;

	public void Spawn()
	{
		Instantiate(ball, new Vector3(0f, -4.3f, -3f), Quaternion.identity);
	}
}

