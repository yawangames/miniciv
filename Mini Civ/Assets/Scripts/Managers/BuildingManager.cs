using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class BuildingManager : MonoBehaviour
{    
    public static BuildingManager Instance;

    public List<Neighborhood> neighborhoods = new List<Neighborhood>();
    public Cell selectedCell;

    private void Awake()
    {
        Instance = this;
    }

    public void TryBuildNeighborhood(Neighborhood neighborhood)
    {
        Debug.Log("Try build");
        if (!selectedCell) return;

        Debug.Log("Cell selected: "+selectedCell.name);

        if (!selectedCell.Buildable()) return;

        Debug.Log("Cell selected is buildable ");

        BuildNeighborhood(neighborhood);
    }

    void BuildNeighborhood(Neighborhood neighborhood)
    {
        Neighborhood newNeighborhood = Instantiate(neighborhood, selectedCell.transform.position, Quaternion.identity);
        neighborhoods.Add(newNeighborhood);
        selectedCell.AddNeighborhood(newNeighborhood);
    }
}
