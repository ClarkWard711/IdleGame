using System.Collections;
using System.Collections.Generic;
using System.Net.Mail;
using UnityEditor.U2D.Animation;
using UnityEngine;

public class Testing : MonoBehaviour
{
	public GameObject[,] Areas = new GameObject[4, 4];
	public GameObject[,] Grids = new GameObject[16, 16];
	public int randomIndexX, randomIndexY;
	void Awake()
	{
		//加入存储系统之后 要记录解锁了哪些位置 以及每个位置的状态
		//添加areas以及标记位置
		for (int j = 0; j < 4; j++)
		{
			for (int k = 0; k < 4; k++)
			{
				GetComponentsInChildren<Areas>()[4 * j + k].x = k;
				GetComponentsInChildren<Areas>()[4 * j + k].y = j;
				GetComponentsInChildren<Areas>()[4 * j + k].ID = 4 * j + k;
				Areas[k, j] = GetComponentsInChildren<Areas>()[4 * j + k].gameObject;
			}
		}
		randomIndexX = Random.Range(0, 4);
		randomIndexY = Random.Range(0, 4);
		//Debug.Log(randomIndexX + "," + randomIndexY);
		Areas[randomIndexX, randomIndexY].GetComponent<SpriteRenderer>().sortingOrder = 1;
		//将开头解锁的grid的collider开启
		//将开头解锁的grid的isLocked改为false
		foreach (Grid Grid in Areas[randomIndexX, randomIndexY].GetComponentsInChildren<Grid>())
		{
			Grid.gameObject.GetComponent<BoxCollider2D>().enabled = true;
			Grid.isLocked = false;
		}
		//给所有的grid赋值x,y
		foreach (GameObject area in Areas)
		{
			for (int j = 0; j < 4; j++)
			{
				for (int k = 0; k < 4; k++)
				{
					area.GetComponentsInChildren<Grid>()[4 * j + k].x = k + area.GetComponentsInChildren<Areas>()[0].x * 4;
					area.GetComponentsInChildren<Grid>()[4 * j + k].y = j + area.GetComponentsInChildren<Areas>()[0].y * 4;
					Grids[k + area.GetComponentsInChildren<Areas>()[0].x * 4, j + area.GetComponentsInChildren<Areas>()[0].y * 4] = area.GetComponentsInChildren<Grid>()[4 * j + k].gameObject;
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
