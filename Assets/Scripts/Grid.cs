using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class Grid : MonoBehaviour, IPointerClickHandler
{
	public int x;
	public int y;
	public int AreaID;
	public State state;
	public bool isLocked = true;
	public bool isBuilt;

	public void OnPointerClick(PointerEventData eventData)
	{
		//Debug.Log(x + "," + y);
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
	Building,
}
