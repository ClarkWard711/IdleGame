using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
	public GameObject BuildingPanel, ResearchPanel, AchievementPanel, SettingPanel, MainPanel;
	public Button BuildingButton, ResearchButton, AchievementButton, SettingButton, CloseButton;

	private void Start()
	{
		BuildingButton.onClick.AddListener(OnBuildingButtonClick);
		ResearchButton.onClick.AddListener(OnResearchButtonClick);
		AchievementButton.onClick.AddListener(OnAchievementButtonClick);
		SettingButton.onClick.AddListener(OnSettingButtonClick);
		CloseButton.onClick.AddListener(OnCloseButtonClick);
	}
	public void OnBuildingButtonClick()
	{
		BuildingPanel.SetActive(true);
		ResearchPanel.SetActive(false);
		AchievementPanel.SetActive(false);
		SettingPanel.SetActive(false);
		MainPanel.SetActive(true);
	}
	public void OnResearchButtonClick()
	{
		BuildingPanel.SetActive(false);
		ResearchPanel.SetActive(true);
		AchievementPanel.SetActive(false);
		SettingPanel.SetActive(false);
		MainPanel.SetActive(true);
	}
	public void OnAchievementButtonClick()
	{
		BuildingPanel.SetActive(false);
		ResearchPanel.SetActive(false);
		AchievementPanel.SetActive(true);
		SettingPanel.SetActive(false);
		MainPanel.SetActive(true);
	}
	public void OnSettingButtonClick()
	{
		BuildingPanel.SetActive(false);
		ResearchPanel.SetActive(false);
		AchievementPanel.SetActive(false);
		SettingPanel.SetActive(true);
		MainPanel.SetActive(true);
	}
	public void OnCloseButtonClick()
	{
		BuildingPanel.SetActive(false);
		ResearchPanel.SetActive(false);
		AchievementPanel.SetActive(false);
		SettingPanel.SetActive(false);
		MainPanel.SetActive(false);
	}
}
