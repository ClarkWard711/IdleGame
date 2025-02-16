using System.Collections;
using System.Collections.Generic;
using System.Net.Mail;
using UnityEditor.U2D.Animation;
using UnityEngine;

public class Testing : MonoBehaviour
{
	public GameObject[,] Areas = new GameObject[4, 4];
	public int randomIndexX, randomIndexY;
	void Awake()
	{
		for (int j = 0; j < 4; j++)
		{
			for (int k = 0; k < 4; k++)
			{
				GetComponentsInChildren<Areas>()[4 * j + k].x = k;
				GetComponentsInChildren<Areas>()[4 * j + k].y = j;
				GetComponentsInChildren<Areas>()[4 * j + k].id = 4 * j + k;
				Areas[k, j] = GetComponentsInChildren<Areas>()[4 * j + k].gameObject;
			}
		}
		randomIndexX = Random.Range(0, 4);
		randomIndexY = Random.Range(0, 4);
		Debug.Log(randomIndexX + "," + randomIndexY);
		Areas[randomIndexX, randomIndexY].GetComponent<SpriteRenderer>().sortingOrder = 1;
		for (int i = 0; i < Areas.Length; i++)
		{
			for (int j = 0; j < 4; j++)
			{
				for (int k = 0; k < 4; k++)
				{
					Areas[randomIndexX, randomIndexY].GetComponentsInChildren<Grid>()[4 * j + k].x = k;
					Areas[randomIndexX, randomIndexY].GetComponentsInChildren<Grid>()[4 * j + k].y = j;
				}
			}
		}
		//Debug.Log(Areas[randomIndexX, randomIndexY].transform.position.x);
		//Debug.Log(Areas[randomIndexX, randomIndexY].transform.position.y);

	}

	private void Start()
	{
		Camera.main.transform.position = new Vector3((-8 + randomIndexX * 4 + 2), (8 - randomIndexY * 4 - 2), Camera.main.transform.position.z);
	}
}
