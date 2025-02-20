using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingController : MonoBehaviour
{
	public static BuildingController Instance;
	public GameObject ButtonPrefab, Content;
	public BuildingConfigSO buildingConfigSO;
	public int BuildingIDOnLoad = -1;
	public bool isGoingToBuild = false;
	private void Awake()
	{
		if (Instance == null)
		{
			Instance = this;
		}
	}

	private void Start()
	{

	}
}
