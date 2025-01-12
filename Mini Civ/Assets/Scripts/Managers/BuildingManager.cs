using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class BuildingManager : MonoBehaviour
{    
    public static BuildingManager Instance;

    public Cell selectedCell;
    public GameObject selectedFeedback;


    public List<Neighborhood> neighborhoods = new List<Neighborhood>();

    private void Awake()
    {
        Instance = this;
    }

    public void TryBuildNeighborhood(Neighborhood neighborhood)
    {
        if (!selectedCell) return;

        if (!selectedCell.Buildable()) return;

        BuildNeighborhood(neighborhood);
    }

    void BuildNeighborhood(Neighborhood neighborhood)
    {
        Neighborhood newNeighborhood = Instantiate(neighborhood, selectedCell.transform.position, Quaternion.identity);
        neighborhoods.Add(newNeighborhood);
        selectedCell.AddNeighborhood(newNeighborhood);
    }

    public void SelectCell(Cell cell)
    { 
        selectedCell = cell;
        selectedFeedback.SetActive(true);
        selectedFeedback.transform.position = cell.transform.position;
    }

    public void UnselectCell()
    {
        selectedCell = null;
        selectedFeedback.SetActive(false);
    }
}
