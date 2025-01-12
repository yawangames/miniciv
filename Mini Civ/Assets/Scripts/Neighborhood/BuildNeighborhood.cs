using UnityEngine;

public class BuildNeighborhood : MonoBehaviour
{
    public Neighborhood Neighborhood;

    public void Build()
    {
        BuildingManager.Instance.TryBuildNeighborhood(Neighborhood);
    }
}
