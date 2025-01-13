using UnityEngine;

public class BuildVillage : MonoBehaviour
{
    public Neighborhood Neighborhood;

    public void Build()
    {
        BuildingManager.Instance.TryBuildVillage();
    }
}
