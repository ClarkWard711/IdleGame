using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ResourceController : MonoBehaviour
{
	public static ResourceController Instance;
	public int CurrentWoodCount, CurrentStoneCount, CurrentIronCount, CurrentWoodLimit = 100, CurrentStoneLimit = 100, CurrentIronLimit = 100;
	public float WoodMultiplier, StoneMultiplier, IronMultiplier;
	public int HandPointWoodAdd = 1, HandPointStoneAdd = 1, HandPointIronAdd = 1;
	public Text WoodStorageText, StoneStorageText, IronStorageText, WoodLimitText, StoneLimitText, IronLimitText;
	public void Awake()
	{
		if (Instance == null)
		{
			Instance = this;
		}
	}

	public void AddResource(string kind, int amount)
	{
		switch (kind)
		{
			case "Wood":
				CurrentWoodCount += amount;
				CurrentWoodCount = Mathf.Clamp(CurrentWoodCount, 0, CurrentWoodLimit);
				break;
			case "Stone":
				CurrentStoneCount += amount;
				CurrentStoneCount = Mathf.Clamp(CurrentStoneCount, 0, CurrentStoneLimit);
				break;
			case "Iron":
				CurrentIronCount += amount;
				CurrentIronCount = Mathf.Clamp(CurrentIronCount, 0, CurrentIronLimit);
				break;
		}
		UpdateResourceUI();
	}

	public void UpdateResourceUI()
	{
		WoodStorageText.text = CurrentWoodCount.ToString();
		StoneStorageText.text = CurrentStoneCount.ToString();
		IronStorageText.text = CurrentIronCount.ToString();
		WoodLimitText.text = CurrentWoodCount.ToString() + "/" + CurrentWoodLimit.ToString();
		StoneLimitText.text = CurrentStoneCount.ToString() + "/" + CurrentStoneLimit.ToString();
		IronLimitText.text = CurrentIronCount.ToString() + "/" + CurrentIronLimit.ToString();
	}
}
