using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class Grid : MonoBehaviour, IPointerClickHandler
{
	public int x;
	public int y;
	public int AreaID;
	public State state;
	public bool isBuilt;
	public bool isWaitingForBuild = false;
	public void Awake()
	{
		state = Random.Range(0, 8) switch
		{
			0 => State.Obstacle,
			1 => State.Wood,
			2 => State.Stone,
			3 => State.Iron,
			4 => State.All,
			5 => State.WoodAndStone,
			6 => State.WoodAndIron,
			7 => State.StoneAndIron,
			_ => State.Obstacle,
		};
	}

	public void OnPointerClick(PointerEventData eventData)
	{
		if (state == State.Obstacle)
		{
			return;
		}
		if (!isBuilt)
		{
			if (isWaitingForBuild)
			{
				isWaitingForBuild = false;
				//取消建造 取消待建造显示
			}
			else if (BuildingController.Instance.isGoingToBuild)
			{
				//检测是否可以建造
				//检测是否有对应资源
				//检测是否有对应建筑
				//检测是否有对应位置
				isWaitingForBuild = true;
				if (state == State.Wood || state == State.All || state == State.WoodAndStone || state == State.WoodAndIron)
				{
					//检测花费 是否有对应资源
				}
				else if (state == State.Stone || state == State.All || state == State.WoodAndStone || state == State.StoneAndIron)
				{

				}
				else if (state == State.Iron || state == State.All || state == State.WoodAndIron || state == State.StoneAndIron)
				{

				}
			}
			else
			{
				//增加对应可获取资源
				if (state == State.Wood || state == State.All || state == State.WoodAndStone || state == State.WoodAndIron)
				{
					//增加木材
					ResourceController.Instance.AddResource("Wood", ResourceController.Instance.HandPointWoodAdd);
				}
				//增加点按可否采集石头的判定
				if (state == State.Stone || state == State.All || state == State.WoodAndStone || state == State.StoneAndIron)
				{
					//增加石头
					ResourceController.Instance.AddResource("Stone", ResourceController.Instance.HandPointStoneAdd);
				}
				//增加点按可否采集铁矿的判定
				if (state == State.Iron || state == State.All || state == State.WoodAndIron || state == State.StoneAndIron)
				{
					//增加铁矿
					ResourceController.Instance.AddResource("Iron", ResourceController.Instance.HandPointIronAdd);
				}
			}
		}
	}
}
public enum State
{
	Obstacle,
	Wood,
	Stone,
	Iron,
	All,
	WoodAndStone,
	WoodAndIron,
	StoneAndIron,
}
