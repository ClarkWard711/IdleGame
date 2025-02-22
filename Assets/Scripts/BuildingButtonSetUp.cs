using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class BuildingButtonSetUp : MonoBehaviour
{
	public Text Name, Description;
	public Image BuildingSprite;
	public GameObject CostPrefab, Content;
	public int ID;
	private void Awake()
	{
		gameObject.GetComponent<Button>().onClick.AddListener(OnClick);
	}
	public void SetUp(BuildingSO buildingSO)
	{
		Name.text = buildingSO.BuildingName;
		Description.text = buildingSO.BuildingDescription;
		BuildingSprite.sprite = buildingSO.BuildingSprite;
		//GameObject cost = Instantiate(CostPrefab, Content.transform);
	}
	public void OnClick()
	{
		BuildingController.Instance.BuildingIDOnLoad = ID;
		BuildingController.Instance.isGoingToBuild = true;
		ButtonController.Instance.OnCloseButtonClick();
		ButtonController.Instance.CancelButton.gameObject.SetActive(true);
	}
}
