using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = (""), fileName = ("BuildingSO_"))]
public class BuildingSO : ScriptableObject
{
	public Sprite BuildingSprite;
	public string BuildingName;
	public string BuildingDescription;
	public int BuildingWoodCost;
	public int BuildingStoneCost;
	public int BuildingIronCost;
	public int BuildingID;
	public int BuildingProduction;
}
