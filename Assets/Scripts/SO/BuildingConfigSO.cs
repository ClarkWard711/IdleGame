using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = (""), fileName = ("BuildingConfigSO"))]
public class BuildingConfigSO : ScriptableObject
{
    public List<BuildingSO> BuildingConfig;
}
