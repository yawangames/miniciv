using UnityEngine;

public class BuildNeighborhood : MonoBehaviour
{
    public Neighborhood Neighborhood;

    public void Build()
    {
        Debug.Log("Click build");
        BuildingManager.Instance.TryBuildNeighborhood(Neighborhood);
    }
}
